using System.Text.Json.Serialization;

namespace PlataformaCursos.Infra.Models.Response
{
    public class CreatePaymentResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("bankSlipUrl")]
        public string BankSlipUrl { get; set; }
        [JsonPropertyName("invoiceUrl")]
        public string InvoiceUrl { get; set; }
    }
}
