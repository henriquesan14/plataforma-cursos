using AutoMapper;
using PlataformaCursos.Application.Commands.CreateLesson;
using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Application.Mappers
{
    public class LessonMapper : Profile
    {
        public LessonMapper()
        {
            CreateMap<CreateLessonCommand, Lesson>();
        }
    }
}
