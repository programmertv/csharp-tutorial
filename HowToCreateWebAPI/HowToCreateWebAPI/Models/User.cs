using System;
using System.ComponentModel.DataAnnotations;
using HowToCreateWebAPI.Contracts;

namespace HowToCreateWebAPI.Models
{
    public class User: IBaseModel
    {
        public int Id { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
