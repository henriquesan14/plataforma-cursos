using PlataformaCursos.Core.Entities;
using PlataformaCursos.Core.Repositories;
using PlataformaCursos.Infra.Persistence.Repositories.Base;

namespace PlataformaCursos.Infra.Persistence.Repositories
{
    public class LessonRepository : RepositoryBase<Lesson>, ILessonRepository
    {
        public LessonRepository(PlataformaCursosDbContext dbContext) : base(dbContext)
        {
        }
    }
}
