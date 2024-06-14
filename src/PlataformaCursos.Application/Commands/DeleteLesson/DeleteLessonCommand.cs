using MediatR;

namespace PlataformaCursos.Application.Commands.DeleteLesson
{
    public class DeleteLessonCommand : IRequest
    {
        public DeleteLessonCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
