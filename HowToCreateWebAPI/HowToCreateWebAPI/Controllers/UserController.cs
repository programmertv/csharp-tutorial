using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HowToCreateWebAPI.Contracts;
using HowToCreateWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HowToCreateWebAPI.Controllers
{
    public class UserController : BaseController<User>
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult UserLogin([FromBody]User user)
        {
            var result = _userRepository.Login(user.Email, user.Password);
            if (result == null)
                return Unauthorized();

            return Ok(result);
        }

    }
}
