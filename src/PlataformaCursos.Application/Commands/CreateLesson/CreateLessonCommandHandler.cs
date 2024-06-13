using AutoMapper;
using MediatR;
using PlataformaCursos.Core.Entities;
using PlataformaCursos.Core.Repositories;

namespace PlataformaCursos.Application.Commands.CreateLesson
{
    public class CreateLessonCommandHandler : IRequestHandler<CreateLessonCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateLessonCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Handle(CreateLessonCommand request, CancellationToken cancellationToken)
        {
            var lesson = _mapper.Map<Lesson>(request);

            await _unitOfWork.Lessons.AddAsync(lesson);
            await _unitOfWork.CompleteAsync();
        }
    }
}
