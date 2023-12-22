using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Db.Entities
{
    [Table("Person", Schema = "Person")]
    public class Person
    {
        [Column("BusinessEntityID")]
        public int PersonId { get; set; }

        [Column("PersonType")]
        public string PersonType { get; set; } = string.Empty;

        [Column("Title")]
        public string? Title { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; } = string.Empty;

        [Column("MiddleName")]
        public string? MiddleName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; } = string.Empty;

        [Column("Suffix")]
        public string? Suffix { get; set; }
    }
}
