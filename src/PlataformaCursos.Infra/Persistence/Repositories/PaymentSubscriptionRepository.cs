using PlataformaCursos.Core.Entities;
using PlataformaCursos.Core.Repositories;
using PlataformaCursos.Infra.Persistence.Repositories.Base;

namespace PlataformaCursos.Infra.Persistence.Repositories
{
    public class PaymentSubscriptionRepository : RepositoryBase<PaymentSubscription>, IPaymentSubscriptionRepository
    {
        public PaymentSubscriptionRepository(PlataformaCursosDbContext dbContext) : base(dbContext)
        {
        }
    }
}
