using MediatR;

namespace PlataformaCursos.Application.Commands.CreatePaymentSubscription
{
    public class CreatePaymentSubscriptionCommand : IRequest
    {
        public decimal Value { get; set; }
        public int UserSubscriptionId { get; set; }
        public DateTime DueDate { get; set; }
    }
}
