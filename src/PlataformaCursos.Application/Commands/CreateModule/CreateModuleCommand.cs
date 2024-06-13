using MediatR;

namespace PlataformaCursos.Application.Commands.CreateModule
{
    public class CreateModuleCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int CourseId { get; set; }
    }
}
