using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Db.Entities
{
    [Table("Employee", Schema = "HumanResources")]
    public class Employee
    {
        [Column("BusinessEntityID")]
        public int EmployeeId { get; set; }

        [Column("NationalIDNumber")]
        public string IdNumber { get; set; } = string.Empty;

        [Column("LoginID")]
        public string LoginId { get; set; } = string.Empty;

        [Column("JobTitle")]
        public string JobTitle { get; set; } = string.Empty;

        [Column("BirthDate")]
        public DateOnly BirthDate { get; set; }

        [Column("MaritalStatus")]
        public char MaritalStatus { get; set; }

        [Column("Gender")]
        public char Gender { get; set; }

        [Column("HireDate")]
        public DateOnly HireDate { get; set; }

        [Column("SalariedFlag")]
        public bool IsSalaried { get;set; }

        [Column("VacationHours")]
        public short VacationHours { get; set; }

        [Column("SickLeaveHours")]
        public short SickLeave { get; set; }

        [Column("CurrentFlag")]
        public bool IsCurrent { get; set; }
    }
}
