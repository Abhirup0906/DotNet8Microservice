using DotNet8Api.Db;
using DotNet8Api.Db.Entities;
using DotNet8Api.Model.Request;
using DotNet8Api.Model.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Orchestrator.AR
{
    public class GetEmployeeDepartmentRequestAR : IStreamRequestHandler<GetEmployeeDepartmentRequest, EmployeeDepartment>
    {
        private readonly IQuery<GetEmployeeDepartmentRequest, IAsyncEnumerable<EmployeeDepartment>> _query;
        public GetEmployeeDepartmentRequestAR(IQuery<GetEmployeeDepartmentRequest, IAsyncEnumerable<EmployeeDepartment>> query) 
        {
            _query = query;
        }

        public async IAsyncEnumerable<EmployeeDepartment> Handle(GetEmployeeDepartmentRequest request, [EnumeratorCancellation] CancellationToken cancellationToken)
        {
            await foreach(var item in _query.ExecuteQuery(request))
            {
                yield return item;
            }            
        }
    }
}
