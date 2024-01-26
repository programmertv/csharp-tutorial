using System;
using AutoMapper;
using Frace.CQRS.AppService.DTOs.Student;
using Frace.CQRS.Core.Commands.Student;
using Frace.CQRS.Core.ViewModels;
using Frace.CQRS.Domain.Models;

namespace Frace.CQRS.AppService.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<CreateStudentDTO, CreateStudentCommand>();
            CreateMap<CreateStudentCommand, Student>()
                .ConstructUsing((s) => new Student(s.FirstName, s.LastName, s.Gender, s.Age));

            CreateMap<Student, Infrastructure.Database.Entities.Student>()
                .ForMember(d => d.Gender, o => o.MapFrom(s => (short)s.Gender));
            CreateMap<Infrastructure.Database.Entities.Student, Student>()
                .ConstructUsing((s) => new Student(s.Id, s.FirstName, s.LastName, s.Gender, s.Age));
            CreateMap<Student, StudentViewModel>();
            CreateMap<UpdateAgeDTO, UpdateAgeCommand>();
            CreateMap<DeleteStudentDTO, DeleteStudentCommand>();
        }
    }
}