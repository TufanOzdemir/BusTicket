using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tufan.ExternalServices.ObiletApi;
using Tufan.Ticket.Domain.Model.Entity;
using Tufan.Ticket.Domain.Model.Request;
using Tufan.Ticket.Domain.Persistance;

namespace Tufan.Ticket.Infrastructure.Repository
{
    public class BusLocationRepository : IBusLocationRepository
    {
        private readonly ObiletApi _obiletApi;
        private readonly IMapper _mapper;

        public BusLocationRepository(ObiletApi obiletApi, IMapper mapper)
        {
            _obiletApi = obiletApi;
            _mapper = mapper;
        }

        public async Task<List<BusLocation>> GetBusLocation(GetBusLocationRequest journeyRequest)
        {
            var request = _mapper.Map<ExternalServices.ObiletApi.Model.BusLocationRequest>(journeyRequest);
            var result = await _obiletApi.GetBusLocation(request);
            return _mapper.Map<List<BusLocation>>(result);
        }
    }
}