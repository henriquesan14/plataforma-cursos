using System.Text.Json.Serialization;

namespace PlataformaCursos.Infra.Models.Request
{
    public class CreatePaymentRequest
    {
        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonPropertyName("billingType")]
        public string BillingType { get; set; }

        [JsonPropertyName("value")]
        public double Value { get; set; }

        [JsonPropertyName("dueDate")]
        public string DueDate { get; set; }
    }
}
