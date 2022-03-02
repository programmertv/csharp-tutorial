using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNetCore_Episode007.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required, MaxLength(1000)]
        public string Address { get; set; }
        [Column(TypeName = "date")]
        public DateTime? BirthDay { get; set; }

        public string TestColumnOnly { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
