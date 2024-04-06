using Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class HolidayController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HolidayController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetByDateAsync(GetHolidayByDateCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetByNameAsync(GetHolidayByNameCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
