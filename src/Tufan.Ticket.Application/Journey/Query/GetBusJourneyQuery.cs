using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Tufan.Ticket.Domain.Model.Entity;
using Tufan.Ticket.Domain.Model.Request;
using Tufan.Ticket.Domain.Services;

namespace Tufan.Ticket.Application.Journey.Query
{
    public class GetBusJourneyQuery : GetBusJourneyRequest, IRequest<List<BusJourney>>
    {
    }

    public class GetBusJourneyQueryHandler : IRequestHandler<GetBusJourneyQuery, List<BusJourney>>
    {
        private readonly JourneyService _journeyService;

        public GetBusJourneyQueryHandler(JourneyService journeyService)
        {
            _journeyService = journeyService;
        }

        public Task<List<BusJourney>> Handle(GetBusJourneyQuery request, CancellationToken cancellationToken)
        {
            return _journeyService.GetBusJourney(request);
        }
    }
}