using System.Text.Json.Serialization;

namespace PlataformaCursos.Infra.Models.Request
{
    public class CreateCustomerRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("cpfCnpj")]
        public string CpfCnpj { get; set; }
        [JsonPropertyName("mobilePhone")]
        public string MobilePhone { get; set; }
    }
}
