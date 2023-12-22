using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Model.Response
{
    public class EmployeeDepartment
    {
        public int EmployeeId { get; set; }
        public string? Title { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string? Suffix { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string DepartmentName { get; set; } = string.Empty;
        public string GroupName { get; set; } = string.Empty;
        public DateOnly StartDate { get; set; }

    }
}
