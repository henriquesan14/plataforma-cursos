using PlataformaCursos.Infra.Models.Request;
using PlataformaCursos.Infra.Models.Response;
using Refit;

namespace PlataformaCursos.Infra.Services
{
    public interface IAsaasService
    {
        [Post("/v3/customers")]
        Task<CreateCustomerResponse> CreateCustomer(CreateCustomerRequest customer);

        [Get("/v3/customers")]
        Task<ResponseBase<Customer>> GetCustomers([Query] string cpfCnpj);

        [Post("/v3/payments")]
        Task<CreatePaymentResponse> CreatePayment(CreatePaymentRequest customer);

    }
}
