using System;
using MediatR;

namespace Frace.CQRS.Core.Commands.Student
{
    public class DeleteStudentCommand : IRequest
    {
        public int Id { get; set; }
    }
}

