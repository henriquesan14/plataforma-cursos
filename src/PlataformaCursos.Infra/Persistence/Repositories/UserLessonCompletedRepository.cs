using PlataformaCursos.Core.Entities;
using PlataformaCursos.Core.Repositories;
using PlataformaCursos.Infra.Persistence.Repositories.Base;

namespace PlataformaCursos.Infra.Persistence.Repositories
{
    public class UserLessonCompletedRepository : RepositoryBase<UserLessonCompleted>, IUserLessonCompletedRepository
    {
        public UserLessonCompletedRepository(PlataformaCursosDbContext dbContext) : base(dbContext)
        {
        }
    }
}
