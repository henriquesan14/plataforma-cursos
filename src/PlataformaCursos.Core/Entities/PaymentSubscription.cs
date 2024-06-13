using PlataformaCursos.Core.Enums;

namespace PlataformaCursos.Core.Entities
{
    public class PaymentSubscription : EntityBase
    {
        public DateTime ProcessingDate { get; set; }
        public StatusPaymentEnum Status { get; set; }
        public string Message { get; set; }
        public decimal Value { get; set; }
        public int UserSubscriptionId { get; set; }
        public virtual UserSubscription UserSubscription { get; set; }
        public string PaymentLink { get; set; }
        public string PaymentExternalId { get; set; }
        public DateTime DueDate { get; set; }
    }
}
