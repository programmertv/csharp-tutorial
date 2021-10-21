using System;
using System.Collections.Generic;
using System.Linq;
using HowToCreateWebAPI.Contracts;
using HowToCreateWebAPI.Models;

namespace HowToCreateWebAPI.Repositories
{
    public class HeroRepository : BaseRepository<Hero>, IHeroRepository
    {
        public HeroRepository() : base() { }

        public IEnumerable<Hero> GetByAge(int age)
        {
            return _table.Where(t => t.Age == age);
        }
    }
}
