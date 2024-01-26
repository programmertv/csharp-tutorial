using System;
using System.ComponentModel.DataAnnotations;

namespace Frace.CQRS.AppService.DTOs.Student
{
    public class BadUpdateAgeDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string LastName { get; set; }
        [Required, Range(0, 1, ErrorMessage = "Male or Female la it puwede (0 = Male, 1 = Female)")]
        public short Gender { get; set; }
        [Required, Range(0, 150, ErrorMessage = "Waso naman ito na edad na yaw****")]
        public int Age { get; set; }
    }
}

