namespace Tufan.Web.UI.Adapters
{
    public class TicketAdapter
    {
        private readonly TicketApi.Client.TicketApi _ticketApi;

        public TicketAdapter(TicketApi.Client.TicketApi ticketApi)
        {
            _ticketApi = ticketApi;
        }
    }
}