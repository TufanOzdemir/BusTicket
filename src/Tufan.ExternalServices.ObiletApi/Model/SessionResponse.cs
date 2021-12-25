using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Tufan.ExternalServices.ObiletApi.Model
{
    [DataContract]
    public class SessionResponse
    {
        [DataMember(Name = "session-id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "session-id")]
        public string SessionId { get; set; }

        [DataMember(Name = "device-id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "device-id")]
        public string DeviceId { get; set; }
    }
}