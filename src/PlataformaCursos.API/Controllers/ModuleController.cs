using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlataformaCursos.Application.Commands.CreateModule;

namespace PlataformaCursos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ModuleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateModuleCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
