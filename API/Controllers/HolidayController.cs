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

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] GetHolidayCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
