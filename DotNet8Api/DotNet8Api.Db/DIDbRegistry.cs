using DotNet8Api.Db.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DotNet8Api.Db
{
    public static class DIDbRegistry
    {
        public static void RegisterDependencies(IServiceCollection services) 
        {
            services.AddDbContext<CommandContext>(options => 
            {
                options.UseSqlServer("Data Source=DESKTOP-8NB5OJT;Initial Catalog=AdventureWorks2022;Integrated Security=true;TrustServerCertificate=True;");
            });
            services.AddDbContext<QueryContext>(options =>
            {
                options.UseSqlServer("Data Source=DESKTOP-8NB5OJT;Initial Catalog=AdventureWorks2022;Integrated Security=true;TrustServerCertificate=True;");
            });
            RepositoryInjection(services);
        }

        private static void RepositoryInjection(IServiceCollection serviceCollection)
        {
            var assembly = typeof(ICommand<>).Assembly;

            foreach (var type in assembly.GetTypes().Where(x => x.IsClass && !x.IsAbstract))
            {
                ContinueIfRepoClass(type, assembly, serviceCollection);
            }
        }

        public static void ContinueIfRepoClass(Type type, Assembly assembly, IServiceCollection serviceCollection)
        {
            var typeinfo = (TypeInfo)type;
            var implInterfaces = typeinfo.ImplementedInterfaces;
            var repointf = typeinfo.ImplementedInterfaces
                .FirstOrDefault(x => x.FullName != null && (x.FullName.Contains(typeof(ICommand<>).Name) || x.FullName.Contains(typeof(IQuery<,>).Name)));
            if (repointf != null)
            {
                foreach (var intf in implInterfaces)
                {
                    if (intf.FullName != null && intf.FullName.Contains(assembly.GetName().Name ?? string.Empty))
                    {
                        serviceCollection.AddScoped(intf, type);
                    }
                }
            }
        }
    }
}
