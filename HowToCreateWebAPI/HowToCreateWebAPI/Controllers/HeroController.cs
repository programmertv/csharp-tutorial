using System;
using HowToCreateWebAPI.Contracts;
using HowToCreateWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HowToCreateWebAPI.Controllers
{
    public class HeroController : BaseController<Hero>
    {
        private readonly IHeroRepository _repository;
        public HeroController(IHeroRepository repository) : base(repository)
        {
            _repository = repository;
        }

        [HttpGet("ByAge/{age}")]
        public IActionResult GetByAge(int age)
        {
            return Ok(_repository.GetByAge(age));
        }
    }
}
