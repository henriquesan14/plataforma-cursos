using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlataformaCursos.Application.Commands.CreateSubscription;

namespace PlataformaCursos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SubscriptionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSubscriptionCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
