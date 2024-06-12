using MediatR;

namespace PlataformaCursos.Application.Commands.CreateCourse
{
    public class CreateCourseCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Cover { get; set; }
    }
}
