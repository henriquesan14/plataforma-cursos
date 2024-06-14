using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlataformaCursos.Application.Commands.CreateLesson;
using PlataformaCursos.Application.Commands.DeleteLesson;
using PlataformaCursos.Application.Commands.UploadVideo;

namespace PlataformaCursos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LessonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateLessonCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload([FromForm] string title, [FromForm] string description, [FromForm] IFormFile videoFile)
        {
            if (videoFile == null || videoFile.Length == 0)
            {
                return BadRequest("Nenhum arquivo de vídeo enviado.");
            }

            using var memoryStream = new MemoryStream();
            await videoFile.CopyToAsync(memoryStream);

            var command = new UploadVideoCommand
            {
                Title = title,
                Description = description,
                Video = new VideoUploadDto
                {
                    FileName = videoFile.FileName,
                    DataStream = memoryStream,
                    Size = videoFile.Length
                }
            };

            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteLessonCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
