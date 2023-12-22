using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Db.Entities
{
    [Table("EmployeeDepartmentHistory", Schema = "HumanResources")]
    public class EmployeeDepartmentHistory
    {
        [Column("BusinessEntityID")]
        public int EmployeeId { get; set; }

        [Column("DepartmentID")]
        public int DepartmentId { get; set; }

        [Column("ShiftID")]
        public short ShiftId { get; set; }

        [Column("StartDate")]
        public DateOnly StartDate { get; set; }

        [Column("EndDate")]
        public DateOnly? EndDate { get; set; }
    }
}
