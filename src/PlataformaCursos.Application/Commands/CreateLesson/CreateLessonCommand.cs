using MediatR;
using PlataformaCursos.Infra.Models.Request;

namespace PlataformaCursos.Application.Commands.CreateLesson
{
    public class CreateLessonCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string LinkVideo { get; set; }
        public int Duration { get; set; }

        public int ModuleId { get; set; }

        public VimeoUploadRequest VimeoUploadRequest { get; set; }
    }
}
