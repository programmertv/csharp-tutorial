using System;
using AutoMapper;
using Frace.CQRS.Core.Commands.Student;
using Frace.CQRS.Core.Queries.Student;
using Frace.CQRS.Core.ViewModels;
using Frace.CQRS.Domain.Contracts;
using MediatR;

namespace Frace.CQRS.Core.QueryHandlers
{
    public class StudentQueryHandler :
        IRequestHandler<GetAllStudentsQuery, IEnumerable<StudentViewModel>>,
        IRequestHandler<GetAllStudentsByGenderQuery, IEnumerable<StudentViewModel>>,
        IRequestHandler<GetStudentByIdQuery, StudentViewModel>
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        public StudentQueryHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<StudentViewModel>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentRepository.GetAll();

            return _mapper.Map<IEnumerable<StudentViewModel>>(students);
        }

        public async Task<StudentViewModel> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetOneById(request.Id);

            return _mapper.Map<StudentViewModel>(student);
        }

        public async Task<IEnumerable<StudentViewModel>> Handle(GetAllStudentsByGenderQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentRepository.GetAllByGender(request.Gender);

            return _mapper.Map<IEnumerable<StudentViewModel>>(students);
        }
    }
}
 