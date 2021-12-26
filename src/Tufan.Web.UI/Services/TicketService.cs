using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tufan.Common.Abstraction;
using Tufan.TicketApi.Client.Models;
using Tufan.Web.UI.Adapters;

namespace Tufan.Web.UI.Services
{
    public class TicketService : IDomainService
    {
        private readonly TicketAdapter _ticketAdapter;

        public TicketService(TicketAdapter ticketAdapter)
        {
            _ticketAdapter = ticketAdapter;
        }

        public async Task<List<BusLocation>> GetBusLocations(string searchWord = null)
        {
            return await _ticketAdapter.GetBusLocations(new GetBusLocationRequest() { Language = "tr-TR", Date = DateTime.Now.ToString(), Data = searchWord });
        }

        public async Task<List<BusJourney>> GetBusJourneys(int startPoint, int endPoint, string date)
        {
            return await _ticketAdapter.GetBusJourneys(new GetBusJourneyRequest()
            {
                Language = "tr-TR",
                Date = DateTime.Now.ToString(),
                Data = new JourneyDataRequest()
                {
                    DepartureDate = date,
                    DestinationId = endPoint,
                    OriginId = startPoint
                }
            });
        }
    }
}