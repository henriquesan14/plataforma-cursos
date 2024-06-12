using MediatR;

namespace PlataformaCursos.Application.Commands.CreateSubscription
{
    public class CreateSubscriptionCommand : IRequest
    {
        public string Name { get; set; }
        public int Duration { get; set; }
    }
}
