using System;
using HowToCreateWebAPI.Models;

namespace HowToCreateWebAPI.Contracts
{
    public interface ITokenService
    {
        string GenererateToken(User user);
        bool IsValid(string token);
    }
}
