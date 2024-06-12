using MediatR;
using PlataformaCursos.Core.Enums;

namespace PlataformaCursos.Application.Commands.CreatePaymentSubscription
{
    public class CreatePaymentSubscriptionCommand : IRequest
    {
        public DateTime ProcessingDate { get; set; }
        public StatusPaymentEnum Status { get; set; }
        public string Message { get; set; }
        public decimal Value { get; set; }
        public int UserSubscriptionId { get; set; }
        public string PaymentLink { get; set; }
        public string PaymentExternalId { get; set; }
        public DateTime DueDate { get; set; }
    }
}
