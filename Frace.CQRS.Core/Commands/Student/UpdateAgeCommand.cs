using System;
using MediatR;

namespace Frace.CQRS.Core.Commands.Student
{
    public class UpdateAgeCommand : IRequest
    {
        public int Id { get; set; }
        public int NewAge { get; set; }
    }
}

