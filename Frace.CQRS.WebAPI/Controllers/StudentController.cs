using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Frace.CQRS.AppService.DTOs.Student;
using Frace.CQRS.Core.Commands.Student;
using Frace.CQRS.Core.Queries.Student;
using Frace.CQRS.Core.ViewModels;
using Frace.CQRS.WebAPI.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Frace.CQRS.WebAPI.Controllers
{
    public class StudentController : BaseController
    {
        public StudentController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return await Handle<IEnumerable<StudentViewModel>>(new GetAllStudentsQuery());
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> GetOne([FromQuery]GetStudentByIdQuery query)
        {
            return await Handle<StudentViewModel>(query);
        }

        [HttpGet]
        [Route("ByGender")]
        public async Task<IActionResult> GetAll([FromQuery]GetAllStudentsByGenderQuery query)
        {
            return await Handle<IEnumerable<StudentViewModel>>(query);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateStudentDTO dto)
        {
            return await Handle<CreateStudentDTO, CreateStudentCommand, int>(dto);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateAgeDTO dto)
        {
            return await Handle<UpdateAgeDTO, UpdateAgeCommand, object>(dto);
        }
    }
}

