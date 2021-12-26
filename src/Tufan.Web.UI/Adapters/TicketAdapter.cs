using System.Collections.Generic;
using System.Threading.Tasks;
using Tufan.TicketApi.Client.Models;

namespace Tufan.Web.UI.Adapters
{
    public class TicketAdapter
    {
        private readonly TicketApi.Client.TicketApi _ticketApi;

        public TicketAdapter(TicketApi.Client.TicketApi ticketApi)
        {
            _ticketApi = ticketApi;
        }

        public async Task<List<BusLocation>> GetBusLocations(GetBusLocationRequest request)
        {
            return await _ticketApi.GetBusLocation(request);
        }

        public async Task<List<BusJourney>> GetBusJourneys(GetBusJourneyRequest request)
        {
            return await _ticketApi.GetBusJourneys(request);
        }
    }
}