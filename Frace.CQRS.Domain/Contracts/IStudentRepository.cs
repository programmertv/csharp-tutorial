using System;
using Frace.CQRS.Domain.Models;

namespace Frace.CQRS.Domain.Contracts
{
	public interface IStudentRepository
	{
        Task<IEnumerable<Student>> GetAll();
        Task<IEnumerable<Student>> GetAllByGender(short gender);
        Task<Student> GetOneById(int id);
        Task<int> Add(Student student);
        Task UpdateAge(int id, int age);
        Task Delete(int id);
    }
}

