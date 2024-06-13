using AutoMapper;
using MediatR;
using PlataformaCursos.Core.Entities;
using PlataformaCursos.Core.Repositories;

namespace PlataformaCursos.Application.Commands.CreateModule
{
    public class CreateModuleCommandHandler : IRequestHandler<CreateModuleCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateModuleCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Handle(CreateModuleCommand request, CancellationToken cancellationToken)
        {
            var module = _mapper.Map<Module>(request);

            await _unitOfWork.Modules.AddAsync(module);
            await _unitOfWork.CompleteAsync();
        }
    }
}
