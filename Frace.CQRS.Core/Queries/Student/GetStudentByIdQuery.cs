using System;
using Frace.CQRS.Core.ViewModels;
using MediatR;

namespace Frace.CQRS.Core.Queries.Student
{
    public class GetStudentByIdQuery : IRequest<StudentViewModel>
    {
        public GetStudentByIdQuery(int id) => Id = id;

        public int Id { get; init; }
    }
}

