using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Db.Entities
{
    [Table("EmployeePayHistory", Schema = "HumanResources")]
    public class EmployeePayHistory
    {
        [Column("BusinessEntityID")]
        public int EmployeeId { get; set; }

        [Column("RateChangeDate")]
        public DateTime RateChangeDate { get; set; }

        [Column("Rate")]
        public decimal Rate {  get; set; }

        [Column("PayFrequency")]
        public short PayFrequency { get; set; }

    }
}
