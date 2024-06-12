using PlataformaCursos.Core.Entities;
using PlataformaCursos.Core.Repositories;
using PlataformaCursos.Infra.Persistence.Repositories.Base;

namespace PlataformaCursos.Infra.Persistence.Repositories
{
    public class UserSubcriptionRepository : RepositoryBase<UserSubscription>, IUserSubscriptionRepository
    {
        public UserSubcriptionRepository(PlataformaCursosDbContext dbContext) : base(dbContext)
        {
        }
    }
}
