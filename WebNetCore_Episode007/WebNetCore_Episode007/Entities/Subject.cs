using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNetCore_Episode007.Entities
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string Title { get; set; }
        [ForeignKey("Student")]
        public int Student_Id { get; set; }

        public virtual Student Student { get; set; }
    }
}
