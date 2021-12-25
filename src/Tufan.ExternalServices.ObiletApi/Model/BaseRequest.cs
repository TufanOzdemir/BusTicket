using Newtonsoft.Json;

namespace Tufan.ExternalServices.ObiletApi.Model
{
    public class BaseRequest
    {
        [JsonProperty("device-session")]
        public DeviceSession DeviceSession { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }
}