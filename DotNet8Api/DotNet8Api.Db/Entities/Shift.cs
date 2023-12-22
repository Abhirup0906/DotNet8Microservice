using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Db.Entities
{
    [Table("Shift", Schema = "HumanResources")]
    public class Shift
    {
        [Column("ShiftID")]
        public short ShiftId { get; set; }

        [Column("Name")]
        public string ShiftName { get; set; } = string.Empty;

        [Column("StartTime")]
        public TimeOnly StartTime { get; set; }

        [Column("EndTime")]
        public TimeOnly EndTime { get; set; }
    }
}
