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
        private readonly ITokenService _tokenService;
        public UserRepository(ITokenService tokenService) : base() {
            _tokenService = tokenService;
        }

        public string Login(string email, string password)
        {
            var founduser = _table
                .FirstOrDefault(u => u.Email == email && u.Password == password);

            return founduser != null ? _tokenService.GenererateToken(founduser) : null;
        }
    }
}
