using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNetCore_Episode007.Entities
{
    [Table("tblPersonalInfo")]
    public class PersonInfo
    {
        [Key]
        public int Id { get; set; }
        [Column("vchName")]
        public string Name { get; set; }
        [Column("vchAddress")]
        public string Address { get; set; }
        [Column("vchEmail")]
        public string Email { get; set; }
        [Column("dtBirthDay")]
        public DateTime? BirthDay { get; set; }
        [Column("iAge")]
        public int? Age { get; set; }
    }
}
