using System.Collections.Generic;
using System.Threading.Tasks;
using Tufan.Common.Abstraction;
using Tufan.Common.Authentication;
using Tufan.Ticket.Domain.Model.Entity;
using Tufan.Ticket.Domain.Model.Request;
using Tufan.Ticket.Domain.Persistance;

namespace Tufan.Ticket.Domain.Services
{
    public class JourneyService : ServiceBase, IDomainService
    {
        private readonly IJourneyRepository _journeyRepository;
        private readonly IDomainPrincipal _domainPrincipal;

        public JourneyService(IJourneyRepository basketRepository, IDomainPrincipal domainPrincipal) : base(domainPrincipal)
        {
            _journeyRepository = basketRepository;
            _domainPrincipal = domainPrincipal;
        }

        public Task<List<BusJourney>> GetBusJourney(GetBusJourneyRequest request)
        {
            request.DeviceSession = FillRequestModel();
            return _journeyRepository.GetBusJourney(request);
        }
    }
}