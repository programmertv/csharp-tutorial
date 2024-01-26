using AutoMapper;
using Frace.CQRS.AppService.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Frace.CQRS.WebAPI.Common
{
    [Route("api/[controller]")]
    public class BaseController : Controller
    {
        protected readonly IMediator _mediator;
        private IMapper _mapper;

        public BaseController(IMediator mediator, IMapper mapper) {
            _mediator = mediator;
            _mapper = mapper;
        }

        protected async Task<IActionResult> Handle<T1, T2, T3>(dynamic dto) {

            var queryOrCommmand = _mapper.Map<T2>(dto);

            return await Handle<T3>(queryOrCommmand);
        }

        protected async Task<IActionResult> Handle<T>(dynamic queryOrCommmand) {
            if (queryOrCommmand == null)
                return BadRequest();

            var result = new QueryOrCommandResult<T>();
            if (ModelState.IsValid)
            {
                try
                {
                    result.Data = await _mediator.Send(queryOrCommmand);
                    result.Success = true;
                }
                catch (Exception ex)
                {
                    result.Messages.Add(ex.Message);
                }
            }
            else {
                result.Messages = ModelState.Values.SelectMany(m => m.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();
            }

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
    }
}

