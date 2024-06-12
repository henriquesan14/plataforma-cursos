using PlataformaCursos.Core.Enums;

namespace PlataformaCursos.Core.Entities
{
    public class UserSubscription : EntityBase
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int SubscriptionId { get; set; }
        public virtual Subscription Subscription { get; set; }
        public StatusSubscriptionEnum Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public virtual PaymentSubscription PaymentSubscription { get; set; }
    }
}
