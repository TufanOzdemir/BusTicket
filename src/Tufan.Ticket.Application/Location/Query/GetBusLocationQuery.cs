using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Tufan.Ticket.Domain.Model.Entity;
using Tufan.Ticket.Domain.Model.Request;
using Tufan.Ticket.Domain.Services;

namespace Tufan.Ticket.Application.Location.Query
{
    public class GetBusLocationQuery : GetBusLocationRequest, IRequest<List<BusLocation>>
    {
    }

    public class GetBusLocationQueryHandler : IRequestHandler<GetBusLocationQuery, List<BusLocation>>
    {
        private readonly BusLocationService _busLocationService;

        public GetBusLocationQueryHandler(BusLocationService busLocationService)
        {
            _busLocationService = busLocationService;
        }

        public Task<List<BusLocation>> Handle(GetBusLocationQuery request, CancellationToken cancellationToken)
        {
            return _busLocationService.GetBusLocation(request);
        }
    }
}