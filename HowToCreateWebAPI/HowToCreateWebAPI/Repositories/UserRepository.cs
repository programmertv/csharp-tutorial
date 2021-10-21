using System;
using System.Collections.Generic;
using System.Linq;
using HowToCreateWebAPI.Contracts;
using HowToCreateWebAPI.Infrastructure;
using HowToCreateWebAPI.Models;

namespace HowToCreateWebAPI.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository() : base() { }
    }
}
