using System;
using System.Collections.Generic;
using HowToCreateWebAPI.Models;

namespace HowToCreateWebAPI.Contracts
{
    public interface IUserRepository: IBaseRepository<User>
    {
        public string Login(string email, string password);
    }
}
