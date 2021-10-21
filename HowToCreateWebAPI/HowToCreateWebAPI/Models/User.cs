using System;
using HowToCreateWebAPI.Contracts;

namespace HowToCreateWebAPI.Models
{
    public class User: IBaseModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
