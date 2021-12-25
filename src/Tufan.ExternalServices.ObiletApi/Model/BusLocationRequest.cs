using Newtonsoft.Json;

namespace Tufan.ExternalServices.ObiletApi.Model
{
    public class BusLocationRequest : BaseRequest
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}