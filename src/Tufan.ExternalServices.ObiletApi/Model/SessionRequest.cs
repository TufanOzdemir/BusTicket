using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Tufan.ExternalServices.ObiletApi.Model
{
    [DataContract]
    public class SessionRequest
    {
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public int Type { get; set; }

        [DataMember(Name = "connection", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "connection")]
        public ConnectionRequest Connection { get; set; }

        [DataMember(Name = "browser", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "browser")]
        public BrowserRequest Browser { get; set; }
    }

    [DataContract]
    public class ConnectionRequest
    {
        [DataMember(Name = "ip-address", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ip-address")]
        public string IpAddress { get; set; }

        [DataMember(Name = "port", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "port")]
        public string Port { get; set; }
    }

    [DataContract]
    public class BrowserRequest
    {
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [DataMember(Name = "version", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
    }
}