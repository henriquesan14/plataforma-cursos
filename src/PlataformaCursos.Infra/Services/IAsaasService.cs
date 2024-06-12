using PlataformaCursos.Infra.Models.Request;
using Refit;

namespace PlataformaCursos.Infra.Services
{
    public interface IAsaasService
    {
        [Post("v3/customers")]
        Task CreateCustomer(CreateCustomerRequest customer);
    }
}
