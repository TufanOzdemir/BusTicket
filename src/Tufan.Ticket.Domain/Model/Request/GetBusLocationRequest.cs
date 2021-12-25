namespace Tufan.Ticket.Domain.Model.Request
{
    public class GetBusLocationRequest
    {
        public string Date { get; set; }
        public string Language { get; set; }
        public DeviceSessionRequest DeviceSession { get; set; }
        public string Data { get; set; }
    }
}