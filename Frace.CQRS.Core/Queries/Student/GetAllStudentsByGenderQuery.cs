using System;
using Frace.CQRS.Core.ViewModels;
using MediatR;

namespace Frace.CQRS.Core.Queries.Student
{
    public class GetAllStudentsByGenderQuery : IRequest<IEnumerable<StudentViewModel>>
    {
        public short Gender { get; set; }
    }
}

