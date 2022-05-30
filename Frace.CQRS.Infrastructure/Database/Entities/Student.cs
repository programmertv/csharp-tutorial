using System;
using System.ComponentModel.DataAnnotations;

namespace Frace.CQRS.Infrastructure.Database.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public short Gender { get; set; }
        [Required, MaxLength(50)]
        public int Age { get; set; }
    }
}

