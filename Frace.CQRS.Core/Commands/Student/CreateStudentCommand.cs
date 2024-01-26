using System;
using MediatR;

namespace Frace.CQRS.Core.Commands.Student
{
    public class CreateStudentCommand : IRequest<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short Gender { get; set; }
        public int Age { get; set; }
    }
}

