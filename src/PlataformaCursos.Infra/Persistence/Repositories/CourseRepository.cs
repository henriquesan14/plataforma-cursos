using PlataformaCursos.Core.Entities;
using PlataformaCursos.Core.Repositories;
using PlataformaCursos.Infra.Persistence.Repositories.Base;

namespace PlataformaCursos.Infra.Persistence.Repositories
{
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository(PlataformaCursosDbContext dbContext) : base(dbContext)
        {
        }
    }
}
