using System;
using System.Collections.Generic;
using HowToCreateWebAPI.Models;

namespace HowToCreateWebAPI.Contracts
{
    public interface IHeroRepository: IBaseRepository<Hero>
    {
        IEnumerable<Hero> GetByAge(int age);
    }
}
