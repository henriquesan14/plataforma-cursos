using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Core.Services
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
