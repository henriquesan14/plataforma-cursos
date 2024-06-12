using PlataformaCursos.Core.Entities;
using PlataformaCursos.Core.Repositories;
using PlataformaCursos.Infra.Persistence.Repositories.Base;

namespace PlataformaCursos.Infra.Persistence.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(PlataformaCursosDbContext dbContext) : base(dbContext)
        {
        }
    }
}
