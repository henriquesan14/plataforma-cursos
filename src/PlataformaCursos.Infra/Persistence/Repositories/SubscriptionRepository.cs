using PlataformaCursos.Core.Entities;
using PlataformaCursos.Core.Repositories;
using PlataformaCursos.Infra.Persistence.Repositories.Base;

namespace PlataformaCursos.Infra.Persistence.Repositories
{
    public class SubscriptionRepository : RepositoryBase<Subscription>, ISubscriptionRepository
    {
        public SubscriptionRepository(PlataformaCursosDbContext dbContext) : base(dbContext)
        {
        }
    }
}
