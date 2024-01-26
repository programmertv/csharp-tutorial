using System;
namespace Frace.CQRS.AppService.DTOs.Student
{
    public class StudentDTO
    {
        public StudentDTO(string fName, string lastName) => FullName = $"{fName} {lastName}";
        public string FullName { get; set; }
    }
}

