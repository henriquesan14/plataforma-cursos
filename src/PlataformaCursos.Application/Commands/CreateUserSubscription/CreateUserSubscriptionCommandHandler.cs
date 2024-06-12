using AutoMapper;
using MediatR;
using PlataformaCursos.Core.Entities;
using PlataformaCursos.Core.Repositories;

namespace PlataformaCursos.Application.Commands.CreateUserSubscription
{
    public class CreateUserSubscriptionCommandHandler : IRequestHandler<CreateUserSubscriptionCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateUserSubscriptionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Handle(CreateUserSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var userSubscription = _mapper.Map<UserSubscription>(request);
            await _unitOfWork.UserSubscriptions.AddAsync(userSubscription);
            await _unitOfWork.CompleteAsync();
        }
    }
}
