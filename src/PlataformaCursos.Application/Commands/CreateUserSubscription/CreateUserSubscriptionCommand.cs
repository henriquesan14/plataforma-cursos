using MediatR;

namespace PlataformaCursos.Application.Commands.CreateUserSubscription
{
    public class CreateUserSubscriptionCommand : IRequest
    {
        public int UserId { get; set; }
        public int SubscriptionId { get; set; }
    }
}
