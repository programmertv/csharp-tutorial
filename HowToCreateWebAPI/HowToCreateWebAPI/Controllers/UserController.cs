using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HowToCreateWebAPI.Contracts;
using HowToCreateWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HowToCreateWebAPI.Controllers
{
    public class UserController : BaseController<User>
    {
        public UserController(IBaseRepository<User> repository) : base(repository)
        {
        }
    }
}
