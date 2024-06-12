using PlataformaCursos.Core.Entities;
using PlataformaCursos.Core.Repositories.Base;

namespace PlataformaCursos.Core.Repositories
{
    public interface ICourseRepository : IAsyncRepository<Course>
    {
    }
}
