using DotNet8Api.Model.Request;
using DotNet8Api.Model.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8Api.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetEmployeeDepartment")]
        public async IAsyncEnumerable<EmployeeDepartment> GetEmployeeDepartment(int? employeeId) 
        {
            await foreach (var item in _mediator.CreateStream(new GetEmployeeDepartmentRequest(employeeId))) 
            { 
                yield return item;
            }            
        }
    }
}
