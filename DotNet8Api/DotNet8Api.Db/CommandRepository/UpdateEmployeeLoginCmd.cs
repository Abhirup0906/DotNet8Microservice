using DotNet8Api.Db.Context;
using DotNet8Api.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Db.CommandRepository
{
    public class UpdateEmployeeLoginCmd : BaseCommand
    {
        public UpdateEmployeeLoginCmd(CommandContext commandContext ):base(commandContext) { }

        public override async Task<bool> ExecuteNonQuery(UpdateEmployeeLogin request)
        {
            var employee = CommandContext.Employees.First(x => x.EmployeeId == request.EmployeeId);
            employee.LoginId = request.LoginId;
            employee.JobTitle = request.JobTitle;
            employee.HireDate = request.HireDate;
            var result = await CommandContext.SaveChangesAsync();
            return result > 0;
        }
    }
}
