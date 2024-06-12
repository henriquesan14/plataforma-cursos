using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlataformaCursos.Application.Commands.CreatePaymentSubscription;

namespace PlataformaCursos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentSubscriptionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PaymentSubscriptionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreatePaymentSubscriptionCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
