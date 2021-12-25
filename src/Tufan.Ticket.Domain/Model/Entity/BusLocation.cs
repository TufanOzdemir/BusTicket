namespace Tufan.Ticket.Domain.Model.Entity
{
    public class GeoLocation
    {
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? Zoom { get; set; }
    }

    public class BusLocation
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public GeoLocation GeoLocation { get; set; }
        public int? Zoom { get; set; }
        public string TzCode { get; set; }
        public string WeatherCode { get; set; }
        public int? Rank { get; set; }
        public string ReferenceCode { get; set; }
        public string Keywords { get; set; }
    }
}