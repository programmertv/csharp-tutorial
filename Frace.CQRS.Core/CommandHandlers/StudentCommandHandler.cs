using System;
using AutoMapper;
using Frace.CQRS.Core.Commands.Student;
using Frace.CQRS.Domain.Contracts;
using Frace.CQRS.Domain.Models;
using MediatR;

namespace Frace.CQRS.Core.CommandHandlers
{
    public class StudentCommandHandler :
        IRequestHandler<CreateStudentCommand, int>,
        IRequestHandler<UpdateAgeCommand>,
        IRequestHandler<DeleteStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentCommandHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = _mapper.Map<Student>(request);
            
            return await _studentRepository.Add(student);
        }

        public async Task<Unit> Handle(UpdateAgeCommand request, CancellationToken cancellationToken)
        {
            await _studentRepository.UpdateAge(request.Id, request.NewAge);
            return new Unit();
        }

        public async Task<Unit> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            await _studentRepository.Delete(request.Id);

            return new Unit();
        }
    }
}