using System;
using System.ComponentModel.DataAnnotations;

namespace Frace.CQRS.AppService.DTOs.Student
{
    public class UpdateAgeDTO
    {
        [Required]
        public int Id { get; set; }
        [Required, Range(0, 150, ErrorMessage = "Waso naman ito na edad na yaw****")]
        public int NewAge { get; set; }
    }
}

