using System;
using MediatR;

namespace Frace.CQRS.Core.Commands.Student
{
    public class DeleteStudentCommand : IRequest
    {
        public DeleteStudentCommand(int id) => Id = id;

        public int Id { get; set; }
    }
}

