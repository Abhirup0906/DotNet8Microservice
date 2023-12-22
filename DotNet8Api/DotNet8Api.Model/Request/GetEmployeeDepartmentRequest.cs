using DotNet8Api.Model.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Model.Request
{
    public record GetEmployeeDepartmentRequest(int? EmployeeId) : IStreamRequest<EmployeeDepartment>
    {        
    }
}
