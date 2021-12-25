using System.Collections.Generic;
using System.Threading.Tasks;
using Tufan.Common.Abstraction;
using Tufan.Common.Authentication;
using Tufan.Ticket.Domain.Model.Entity;
using Tufan.Ticket.Domain.Model.Request;
using Tufan.Ticket.Domain.Persistance;

namespace Tufan.Ticket.Domain.Services
{
    public class BusLocationService : ServiceBase, IDomainService
    {
        private readonly IBusLocationRepository _busLocationRepository;
        private readonly IDomainPrincipal _domainPrincipal;

        public BusLocationService(IBusLocationRepository busLocationRepository, IDomainPrincipal domainPrincipal) : base(domainPrincipal)
        {
            _busLocationRepository = busLocationRepository;
            _domainPrincipal = domainPrincipal;
        }

        public Task<List<BusLocation>> GetBusLocation(GetBusLocationRequest request)
        {
            request.DeviceSession = FillRequestModel();
            return _busLocationRepository.GetBusLocation(request);
        }
    }
}