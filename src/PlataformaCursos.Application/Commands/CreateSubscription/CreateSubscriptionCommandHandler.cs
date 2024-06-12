using AutoMapper;
using MediatR;
using PlataformaCursos.Core.Entities;
using PlataformaCursos.Core.Repositories;

namespace PlataformaCursos.Application.Commands.CreateSubscription
{
    public class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateSubscriptionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var subscription = _mapper.Map<Subscription>(request);
            await _unitOfWork.Subscriptions.AddAsync(subscription);
            await _unitOfWork.CompleteAsync();
        }
    }
}
