using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tufan.TicketApi.Client.Models
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
    public class Stop 
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }        
        /// <summary>
        /// Gets or Sets Station
        /// </summary>
        [DataMember(Name = "station", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "station")]
        public string Station { get; set; }        
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "time")]
        public DateTime Time { get; set; }        
        /// <summary>
        /// Gets or Sets IsOrigin
        /// </summary>
        [DataMember(Name = "isOrigin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isOrigin")]
        public bool IsOrigin { get; set; }        
        /// <summary>
        /// Gets or Sets IsDestination
        /// </summary>
        [DataMember(Name = "isDestination", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isDestination")]
        public bool IsDestination { get; set; }        
    }
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Policy 
    {
        /// <summary>
        /// Gets or Sets MaxSeats
        /// </summary>
        [DataMember(Name = "maxSeats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "maxSeats")]
        public Object MaxSeats { get; set; }        
        /// <summary>
        /// Gets or Sets MaxSingle
        /// </summary>
        [DataMember(Name = "maxSingle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "maxSingle")]
        public Object MaxSingle { get; set; }        
        /// <summary>
        /// Gets or Sets MaxSingleMales
        /// </summary>
        [DataMember(Name = "maxSingleMales", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "maxSingleMales")]
        public int MaxSingleMales { get; set; }        
        /// <summary>
        /// Gets or Sets MaxSingleFemales
        /// </summary>
        [DataMember(Name = "maxSingleFemales", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "maxSingleFemales")]
        public int MaxSingleFemales { get; set; }        
        /// <summary>
        /// Gets or Sets MixedGenders
        /// </summary>
        [DataMember(Name = "mixedGenders", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mixedGenders")]
        public bool MixedGenders { get; set; }        
        /// <summary>
        /// Gets or Sets GovId
        /// </summary>
        [DataMember(Name = "govId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "govId")]
        public bool GovId { get; set; }        
        /// <summary>
        /// Gets or Sets Lht
        /// </summary>
        [DataMember(Name = "lht", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lht")]
        public bool Lht { get; set; }        
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
    public class Journey 
    {
        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }        
        /// <summary>
        /// Gets or Sets Stops
        /// </summary>
        [DataMember(Name = "stops", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stops")]
        public List<Stop> Stops { get; set; }        
        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name = "origin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }        
        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name = "destination", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "destination")]
        public string Destination { get; set; }        
        /// <summary>
        /// Gets or Sets Departure
        /// </summary>
        [DataMember(Name = "departure", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "departure")]
        public DateTime Departure { get; set; }        
        /// <summary>
        /// Gets or Sets Arrival
        /// </summary>
        [DataMember(Name = "arrival", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "arrival")]
        public DateTime Arrival { get; set; }        
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }        
        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }        
        /// <summary>
        /// Gets or Sets OriginalPrice
        /// </summary>
        [DataMember(Name = "originalPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "originalPrice")]
        public double OriginalPrice { get; set; }        
        /// <summary>
        /// Gets or Sets InternetPrice
        /// </summary>
        [DataMember(Name = "internetPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "internetPrice")]
        public double InternetPrice { get; set; }        
        /// <summary>
        /// Gets or Sets ProviderInternetPrice
        /// </summary>
        [DataMember(Name = "providerInternetPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "providerInternetPrice")]
        public Object ProviderInternetPrice { get; set; }        
        /// <summary>
        /// Gets or Sets Booking
        /// </summary>
        [DataMember(Name = "booking", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "booking")]
        public Object Booking { get; set; }        
        /// <summary>
        /// Gets or Sets BusName
        /// </summary>
        [DataMember(Name = "busName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "busName")]
        public string BusName { get; set; }        
        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "policy")]
        public Policy Policy { get; set; }        
        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name = "features", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "features")]
        public List<string> Features { get; set; }        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public Object Description { get; set; }        
        /// <summary>
        /// Gets or Sets Available
        /// </summary>
        [DataMember(Name = "available", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "available")]
        public Object Available { get; set; }        
    }
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class BusLocation 
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }        
        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name = "parentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parentId")]
        public int ParentId { get; set; }        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }        
        /// <summary>
        /// Gets or Sets GeoLocation
        /// </summary>
        [DataMember(Name = "geoLocation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "geoLocation")]
        public GeoLocation GeoLocation { get; set; }        
        /// <summary>
        /// Gets or Sets Zoom
        /// </summary>
        [DataMember(Name = "zoom", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "zoom")]
        public int? Zoom { get; set; }        
        /// <summary>
        /// Gets or Sets TzCode
        /// </summary>
        [DataMember(Name = "tzCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tzCode")]
        public string TzCode { get; set; }        
        /// <summary>
        /// Gets or Sets WeatherCode
        /// </summary>
        [DataMember(Name = "weatherCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "weatherCode")]
        public string WeatherCode { get; set; }        
        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rank")]
        public int? Rank { get; set; }        
        /// <summary>
        /// Gets or Sets ReferenceCode
        /// </summary>
        [DataMember(Name = "referenceCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "referenceCode")]
        public string ReferenceCode { get; set; }        
        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name = "keywords", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "keywords")]
        public string Keywords { get; set; }        
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
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class GeoLocation 
    {
        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; set; }        
        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "longitude")]
        public double? Longitude { get; set; }        
        /// <summary>
        /// Gets or Sets Zoom
        /// </summary>
        [DataMember(Name = "zoom", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "zoom")]
        public int? Zoom { get; set; }        
    }
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class BusJourney 
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }        
        /// <summary>
        /// Gets or Sets PartnerId
        /// </summary>
        [DataMember(Name = "partnerId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "partnerId")]
        public int PartnerId { get; set; }        
        /// <summary>
        /// Gets or Sets PartnerName
        /// </summary>
        [DataMember(Name = "partnerName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "partnerName")]
        public string PartnerName { get; set; }        
        /// <summary>
        /// Gets or Sets RouteId
        /// </summary>
        [DataMember(Name = "routeId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "routeId")]
        public int RouteId { get; set; }        
        /// <summary>
        /// Gets or Sets BusType
        /// </summary>
        [DataMember(Name = "busType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "busType")]
        public string BusType { get; set; }        
        /// <summary>
        /// Gets or Sets BusTypeName
        /// </summary>
        [DataMember(Name = "busTypeName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "busTypeName")]
        public string BusTypeName { get; set; }        
        /// <summary>
        /// Gets or Sets TotalSeats
        /// </summary>
        [DataMember(Name = "totalSeats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalSeats")]
        public int TotalSeats { get; set; }        
        /// <summary>
        /// Gets or Sets AvailableSeats
        /// </summary>
        [DataMember(Name = "availableSeats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "availableSeats")]
        public int AvailableSeats { get; set; }        
        /// <summary>
        /// Gets or Sets Journey
        /// </summary>
        [DataMember(Name = "journey", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "journey")]
        public Journey Journey { get; set; }        
        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name = "features", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "features")]
        public List<Feature> Features { get; set; }        
        /// <summary>
        /// Gets or Sets OriginLocation
        /// </summary>
        [DataMember(Name = "originLocation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "originLocation")]
        public string OriginLocation { get; set; }        
        /// <summary>
        /// Gets or Sets DestinationLocation
        /// </summary>
        [DataMember(Name = "destinationLocation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "destinationLocation")]
        public string DestinationLocation { get; set; }        
        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "isActive", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isActive")]
        public bool IsActive { get; set; }        
        /// <summary>
        /// Gets or Sets OriginLocationId
        /// </summary>
        [DataMember(Name = "originLocationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "originLocationId")]
        public int OriginLocationId { get; set; }        
        /// <summary>
        /// Gets or Sets DestinationLocationId
        /// </summary>
        [DataMember(Name = "destinationLocationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "destinationLocationId")]
        public int DestinationLocationId { get; set; }        
        /// <summary>
        /// Gets or Sets IsPromoted
        /// </summary>
        [DataMember(Name = "isPromoted", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPromoted")]
        public bool IsPromoted { get; set; }        
        /// <summary>
        /// Gets or Sets CancellationOffset
        /// </summary>
        [DataMember(Name = "cancellationOffset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cancellationOffset")]
        public int CancellationOffset { get; set; }        
        /// <summary>
        /// Gets or Sets HasBusShuttle
        /// </summary>
        [DataMember(Name = "hasBusShuttle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasBusShuttle")]
        public bool HasBusShuttle { get; set; }        
        /// <summary>
        /// Gets or Sets DisableSalesWithoutGovId
        /// </summary>
        [DataMember(Name = "disableSalesWithoutGovId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "disableSalesWithoutGovId")]
        public bool DisableSalesWithoutGovId { get; set; }        
        /// <summary>
        /// Gets or Sets DisplayOffset
        /// </summary>
        [DataMember(Name = "displayOffset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayOffset")]
        public string DisplayOffset { get; set; }        
        /// <summary>
        /// Gets or Sets PartnerRating
        /// </summary>
        [DataMember(Name = "partnerRating", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "partnerRating")]
        public double PartnerRating { get; set; }        
        /// <summary>
        /// Gets or Sets HasDynamicPricing
        /// </summary>
        [DataMember(Name = "hasDynamicPricing", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasDynamicPricing")]
        public bool HasDynamicPricing { get; set; }        
        /// <summary>
        /// Gets or Sets DisableSalesWithoutHesCode
        /// </summary>
        [DataMember(Name = "disableSalesWithoutHesCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "disableSalesWithoutHesCode")]
        public bool DisableSalesWithoutHesCode { get; set; }        
        /// <summary>
        /// Gets or Sets DisableSingleSeatSelection
        /// </summary>
        [DataMember(Name = "disableSingleSeatSelection", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "disableSingleSeatSelection")]
        public bool DisableSingleSeatSelection { get; set; }        
        /// <summary>
        /// Gets or Sets ChangeOffset
        /// </summary>
        [DataMember(Name = "changeOffset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "changeOffset")]
        public int ChangeOffset { get; set; }        
        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rank")]
        public int Rank { get; set; }        
        /// <summary>
        /// Gets or Sets DisplayCouponCodeInput
        /// </summary>
        [DataMember(Name = "displayCouponCodeInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayCouponCodeInput")]
        public bool DisplayCouponCodeInput { get; set; }        
    }
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Feature 
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }        
        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "priority")]
        public int Priority { get; set; }        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public Object Description { get; set; }        
        /// <summary>
        /// Gets or Sets IsPromoted
        /// </summary>
        [DataMember(Name = "isPromoted", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPromoted")]
        public bool IsPromoted { get; set; }        
        /// <summary>
        /// Gets or Sets BackColor
        /// </summary>
        [DataMember(Name = "backColor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "backColor")]
        public Object BackColor { get; set; }        
        /// <summary>
        /// Gets or Sets ForeColor
        /// </summary>
        [DataMember(Name = "foreColor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "foreColor")]
        public Object ForeColor { get; set; }        
    }
}