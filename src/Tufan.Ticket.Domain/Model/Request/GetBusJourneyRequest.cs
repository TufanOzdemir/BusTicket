namespace Tufan.Ticket.Domain.Model.Request
{
    public class GetBusJourneyRequest
    {
        public string Date { get; set; }
        public string Language { get; set; }
        public JourneyDataRequest Data { get; set; }
        public DeviceSessionRequest DeviceSession { get; set; }
    }

    public class JourneyDataRequest
    {
        public int OriginId { get; set; }
        public int DestinationId { get; set; }
        public string DepartureDate { get; set; }
    }
}