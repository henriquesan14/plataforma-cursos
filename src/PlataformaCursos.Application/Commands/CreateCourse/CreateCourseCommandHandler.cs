using AutoMapper;
using MediatR;
using PlataformaCursos.Core.Entities;
using PlataformaCursos.Core.Repositories;

namespace PlataformaCursos.Application.Commands.CreateCourse
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCourseCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = _mapper.Map<Course>(request);

            await _unitOfWork.Courses.AddAsync(course);
            await _unitOfWork.CompleteAsync();
        }
    }
}
