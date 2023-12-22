using DotNet8Api.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Orchestrator
{
    public static class DIOrchestraRegistry
    {
        public static void RegisterDependencies(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMediatR(cfg => 
            {
                cfg.RegisterServicesFromAssemblies(typeof(DIRegistry).Assembly, typeof(DIOrchestraRegistry).Assembly);
            });
        }
    }
}
