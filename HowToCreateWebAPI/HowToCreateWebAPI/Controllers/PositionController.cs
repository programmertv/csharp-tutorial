using System;
using HowToCreateWebAPI.Contracts;
using HowToCreateWebAPI.Models;

namespace HowToCreateWebAPI.Controllers
{
    public class PositionController : BaseController<Position>
    {
        public PositionController(IBaseRepository<Position> repository) : base(repository)
        {
        }
    }
}
