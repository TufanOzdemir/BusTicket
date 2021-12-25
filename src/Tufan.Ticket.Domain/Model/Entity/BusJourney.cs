using System.Collections.Generic;

namespace Tufan.Ticket.Domain.Model.Entity
{
    public class BusJourney
    {
        public int Id { get; set; }
        public int PartnerId { get; set; }
        public string PartnerName { get; set; }
        public int RouteId { get; set; }
        public string BusType { get; set; }
        public string BusTypeName { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public Journey Journey { get; set; }
        public List<Feature> Features { get; set; }
        public string OriginLocation { get; set; }
        public string DestinationLocation { get; set; }
        public bool IsActive { get; set; }
        public int OriginLocationId { get; set; }
        public int DestinationLocationId { get; set; }
        public bool IsPromoted { get; set; }
        public int CancellationOffset { get; set; }
        public bool HasBusShuttle { get; set; }
        public bool DisableSalesWithoutGovId { get; set; }
        public string DisplayOffset { get; set; }
        public double PartnerRating { get; set; }
        public bool HasDynamicPricing { get; set; }
        public bool DisableSalesWithoutHesCode { get; set; }
        public bool DisableSingleSeatSelection { get; set; }
        public int ChangeOffset { get; set; }
        public int Rank { get; set; }
        public bool DisplayCouponCodeInput { get; set; }
    }
}