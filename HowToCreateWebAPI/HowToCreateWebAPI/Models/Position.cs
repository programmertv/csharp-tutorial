using System;
using System.ComponentModel.DataAnnotations;
using HowToCreateWebAPI.Contracts;

namespace HowToCreateWebAPI.Models
{
    public class Position: IBaseModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string Description { get; set; }
    }
}
