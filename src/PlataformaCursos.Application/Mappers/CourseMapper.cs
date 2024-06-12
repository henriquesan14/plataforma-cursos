using AutoMapper;
using PlataformaCursos.Application.Commands.CreateCourse;
using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Application.Mappers
{
    public class CourseMapper : Profile
    {
        public CourseMapper()
        {
            CreateMap<CreateCourseCommand, Course>();
        }
    }
}
