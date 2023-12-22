using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Db.Entities
{
    [Table("Department", Schema = "HumanResources")]
    public class Department
    {
        [Column("DepartmentID")]
        public int DepartmentId { get; set; }

        [Column("Name")]
        public string DepartmentName { get; set; } = string.Empty;

        [Column("GroupName")]
        public string GroupName { get; set; } = string.Empty;

        [Column("ModifiedDate")]
        public DateTime ModifiedDate { get; set; }
    }
}
