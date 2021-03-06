using System.Collections.Generic;
using System.Threading.Tasks;
using Tufan.Common.Configuration;
using Tufan.Common.Http;
using Tufan.TicketApi.Client.Models;

namespace Tufan.TicketApi.Client
{
    public class TicketApi
    {
        private readonly HttpMethodCreator _httpMethodCreator;
        private readonly UrlConfig _urlConfig;

        public TicketApi(HttpMethodCreator httpMethodCreator, UrlConfig urlConfig)
        {
            _httpMethodCreator = httpMethodCreator;
            _urlConfig = urlConfig;
        }

        public async Task<List<BusJourney>> GetBusJourneys(GetBusJourneyRequest request)
        {
            return await _httpMethodCreator.Get<List<BusJourney>>($"{_urlConfig.TicketUrl}/api/journey?Date={request.Date}&Language={request.Language}" +
                $"&Data.OriginId={request.Data.OriginId}&Data.DestinationId={request.Data.DestinationId}&Data.DepartureDate={request.Data.DepartureDate}");
        }

        public async Task<List<BusLocation>> GetBusLocation(GetBusLocationRequest request)
        {
            return await _httpMethodCreator.Get<List<BusLocation>>($"{_urlConfig.TicketUrl}/api/buslocation?Date={request.Date}&Language={request.Language}&Data={request.Data}");
        }
    }
}