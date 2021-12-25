using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tufan.ExternalServices.ObiletApi;
using Tufan.Ticket.Domain.Model.Entity;
using Tufan.Ticket.Domain.Model.Request;
using Tufan.Ticket.Domain.Persistance;

namespace Tufan.Ticket.Infrastructure.Repository
{
    public class JourneyRepository : IJourneyRepository
    {
        private readonly ObiletApi _obiletApi;
        private readonly IMapper _mapper;

        public JourneyRepository(ObiletApi obiletApi, IMapper mapper)
        {
            _obiletApi = obiletApi;
            _mapper = mapper;
        }

        public async Task<List<BusJourney>> GetBusJourney(GetBusJourneyRequest journeyRequest)
        {
            var request = _mapper.Map<ExternalServices.ObiletApi.Model.BusJourneyRequest>(journeyRequest);
            var result = await _obiletApi.GetBusJourneys(request);
            return _mapper.Map<List<BusJourney>>(result);
        }
    }
}