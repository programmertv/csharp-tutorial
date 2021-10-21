using System;
using HowToCreateWebAPI.Contracts;

namespace HowToCreateWebAPI.Models
{
    public class Hero: IBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
