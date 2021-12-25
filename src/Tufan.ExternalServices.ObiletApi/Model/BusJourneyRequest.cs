using Newtonsoft.Json;

namespace Tufan.ExternalServices.ObiletApi.Model
{
    public class JourneyRequestData
    {
        [JsonProperty("origin-id")]
        public int OriginId { get; set; }

        [JsonProperty("destination-id")]
        public int DestinationId { get; set; }

        [JsonProperty("departure-date")]
        public string DepartureDate { get; set; }
    }

    public class BusJourneyRequest
    {
        [JsonProperty("device-session")]
        public DeviceSession DeviceSession { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("data")]
        public JourneyRequestData Data { get; set; }
    }
}