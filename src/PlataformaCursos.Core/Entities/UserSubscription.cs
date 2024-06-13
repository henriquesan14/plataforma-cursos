using PlataformaCursos.Core.Enums;

namespace PlataformaCursos.Core.Entities
{
    public class UserSubscription : EntityBase
    {
        public UserSubscription()
        {
            Status = StatusSubscriptionEnum.PENDING;
            StartDate = DateTime.UtcNow;
            ExpirationDate = DateTime.UtcNow.AddMonths(1);
        }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int SubscriptionId { get; set; }
        public virtual Subscription Subscription { get; set; }
        public StatusSubscriptionEnum Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public virtual List<PaymentSubscription> PaymentsSubscription { get; set; }

    }
}
