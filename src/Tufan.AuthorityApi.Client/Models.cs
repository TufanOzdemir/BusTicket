using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tufan.AuthorityApi.Client.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class BadRequestErrorResponse 
    {
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errors")]
        public List<BadRequestErrorItemModel> Errors { get; set; }        
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }        
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }        
    }
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class SessionRequest 
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public int Type { get; set; }        
        /// <summary>
        /// Gets or Sets Connection
        /// </summary>
        [DataMember(Name = "connection", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "connection")]
        public ConnectionRequest Connection { get; set; }        
        /// <summary>
        /// Gets or Sets Browser
        /// </summary>
        [DataMember(Name = "browser", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "browser")]
        public BrowserRequest Browser { get; set; }        
    }
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ConnectionRequest 
    {
        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name = "ipAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }        
        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name = "port", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "port")]
        public string Port { get; set; }        
    }
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class BrowserRequest 
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }        
    }
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class BadRequestErrorItemModel 
    {
        /// <summary>
        /// Gets or Sets PropertyName
        /// </summary>
        [DataMember(Name = "propertyName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "propertyName")]
        public string PropertyName { get; set; }        
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }        
        /// <summary>
        /// Gets or Sets AttemptedValue
        /// </summary>
        [DataMember(Name = "attemptedValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attemptedValue")]
        public Object AttemptedValue { get; set; }        
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }        
    }
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ErrorResponse 
    {
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }        
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }        
    }
}