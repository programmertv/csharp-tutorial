using System;
using Frace.CQRS.Core.ViewModels;
using Frace.CQRS.Domain.Enumerations;
using MediatR;

namespace Frace.CQRS.Core.Queries.Student
{
    public class GetAllStudentsByGenderQuery : IRequest<IEnumerable<StudentViewModel>>
    {
        public GetAllStudentsByGenderQuery(Gender gender) => Gender = (short)gender;

        public short Gender { get; init; }
    }
}

