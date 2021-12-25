namespace Tufan.Ticket.Models.Request
{
    public class GetBusJourneyRequest
    {
        public string Date { get; set; }
        public string Language { get; set; }
        public JourneyDataRequest Data { get; set; }
    }

    public class JourneyDataRequest
    {
        /// <summary>
        /// Çıkış Noktası
        /// </summary>
        public int OriginId { get; set; }
        /// <summary>
        /// Varış Noktası
        /// </summary>
        public int DestinationId { get; set; }
        /// <summary>
        /// Çıkış Tarihi
        /// </summary>
        public string DepartureDate { get; set; }
    }
}