using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Model.Request
{
    public record UpdateEmployeeLogin(int EmployeeId, string LoginId, string JobTitle, DateOnly HireDate) : IRequest<bool>
    {
    }
}
