using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HowToCreateWebAPI.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HowToCreateWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class BaseController<T> : Controller
    {
        private readonly IBaseRepository<T> _repository;
        public BaseController(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            var user = _repository.GetOne(id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create([FromBody] T user)
        {
            _repository.Add(user);

            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] T user)
        {
            _repository.Update(user);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);

            return Ok();
        }
    }
}
