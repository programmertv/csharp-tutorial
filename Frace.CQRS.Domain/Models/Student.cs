using System;
using Frace.CQRS.Domain.Enumerations;

namespace Frace.CQRS.Domain.Models
{
    public class Student
    {
        public Student(string firstname, string lastName, short gender, int age) {
            FirstName = firstname;
            LastName = lastName;
            Gender = (Gender)gender;
            Age = age;
        }

        public Student(int id, string firstname, string lastName, short gender, int age)
            : this(firstname, lastName, gender, age) {
            Id = id;
        }

        public int Id { get; init; }
        public string FirstName { get; private set; }


        public string LastName { get; private set; }
        public Gender Gender { get; private set; }
        public int Age { get; private set; }
    }
}

