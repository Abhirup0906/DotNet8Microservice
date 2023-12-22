using DotNet8Api.Db.Context;
using DotNet8Api.Model.Request;
using DotNet8Api.Model.Response;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DotNet8Api.Db.QueryRepository
{
    public class EmployeeDepartmentQuery : IQuery<GetEmployeeDepartmentRequest, IAsyncEnumerable<EmployeeDepartment>>
    {
        private readonly QueryContext _queryContext;

        public EmployeeDepartmentQuery(QueryContext queryContext) 
        {
            _queryContext = queryContext;
        }

        public async IAsyncEnumerable<EmployeeDepartment> ExecuteQuery(GetEmployeeDepartmentRequest request)
        {
            var result = from emp in _queryContext.Employees.Where(x => request.EmployeeId == null || x.EmployeeId == request.EmployeeId)
                         join person in _queryContext.Persons on emp.EmployeeId equals person.PersonId
                         join empDept in _queryContext.EmployeeDepartmentHistories on emp.EmployeeId equals empDept.EmployeeId
                         join dept in _queryContext.Departments on empDept.DepartmentId equals dept.DepartmentId
                         select new EmployeeDepartment
                         {
                             EmployeeId = emp.EmployeeId,
                             DepartmentName = dept.DepartmentName,
                             FirstName = person.FirstName,
                             MiddleName = person.MiddleName,
                             LastName = person.LastName,
                             GroupName = dept.GroupName,
                             JobTitle = emp.JobTitle,
                             StartDate = empDept.StartDate,
                             Suffix = person.Suffix,
                             Title = person.Title
                         };
            await foreach (var item in result.AsAsyncEnumerable()) 
            { 
                yield return item;
            }
        }
    }
}
