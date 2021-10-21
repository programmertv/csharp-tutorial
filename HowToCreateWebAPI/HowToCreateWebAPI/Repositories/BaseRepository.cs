using System;
using System.Collections.Generic;
using System.Linq;
using HowToCreateWebAPI.Contracts;
using HowToCreateWebAPI.Infrastructure;

namespace HowToCreateWebAPI.Repositories
{
    public class BaseRepository<T>: IBaseRepository<T>
        where T: IBaseModel
    {
        protected readonly FakeDbContext _db = new FakeDbContext();
        protected readonly List<T> _table;

        public BaseRepository()
        {
            _table = _db.GetTable<T>();
        }

        public void Add(T model)
        {
            model.Id = _table.Count + 1;
            _table.Add(model);
        }

        public IEnumerable<T> GetAll()
        {
            return _table;
        }

        public T GetOne(int id)
        {
            return _table.FirstOrDefault(u => u.Id == id);
        }

        public void Update(T model)
        {
            var index = _table.FindIndex(u => u.Id == model.Id);
            _table[index] = model;
        }

        public void Delete(int id)
        {
            _table.RemoveAll(u => u.Id == id);
        }
    }
}
