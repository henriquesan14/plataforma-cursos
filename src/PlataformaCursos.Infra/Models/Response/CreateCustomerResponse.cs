using System.Text.Json.Serialization;

namespace PlataformaCursos.Infra.Models.Response
{
    public class CreateCustomerResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
