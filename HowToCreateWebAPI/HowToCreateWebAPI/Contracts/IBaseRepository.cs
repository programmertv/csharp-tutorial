using System;
using System.Collections.Generic;
using HowToCreateWebAPI.Models;

namespace HowToCreateWebAPI.Contracts
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetOne(int id);
        void Add(T user);
        void Update(T user);
        void Delete(int id);
    }
}
