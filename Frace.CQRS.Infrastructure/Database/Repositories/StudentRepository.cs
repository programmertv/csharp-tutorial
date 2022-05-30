using System;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Frace.CQRS.Domain.Contracts;
using Frace.CQRS.Domain.Models;
using Frace.CQRS.Infrastructure.Database.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Frace.CQRS.Infrastructure.Database.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolDBContext _db;
        private readonly IMapper _mapper;

        public StudentRepository(SchoolDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _db.Students
                .ProjectTo<Student>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<Student> GetOneById(int id)
        {
            return await _db.Students
                .Where(t => t.Id == id)
                .ProjectTo<Student>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public async Task<int> Add(Student student)
        {
            var entity = _mapper.Map<Entities.Student>(student);
            _db.Students.Add(entity);
            await _db.SaveChangesAsync();

            return entity.Id;
        }

        public async Task UpdateAge(int id, int age)
        {
            var entity = await FindStudentById(id);
            entity.Age = age;
            await _db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await FindStudentById(id);
            _db.Students.Remove(entity);
            await _db.SaveChangesAsync();
        }

        private async Task<Entities.Student> FindStudentById(int id)
        {
            var found = await _db.Students.FindAsync(id);
            if (found == null)
                throw new NullReferenceException();

            return found;
        }

        public async Task<IEnumerable<Student>> GetAllByGender(short gender)
        {
            return await _db.Students
                .Where(t => t.Gender == gender)
                .ProjectTo<Student>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}

