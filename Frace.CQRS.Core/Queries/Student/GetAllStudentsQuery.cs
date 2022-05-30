using System;
using Frace.CQRS.Core.ViewModels;
using MediatR;

namespace Frace.CQRS.Core.Queries.Student
{
    public class GetAllStudentsQuery : IRequest<IEnumerable<StudentViewModel>>
    {
    }
}

