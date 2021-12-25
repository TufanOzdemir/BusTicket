using MediatR;
using Tufan.Common.Abstraction;
using Tufan.Ticket.Domain.Persistance;

namespace Tufan.Ticket.Domain.Services
{
    public class TicketService : IDomainService
    {
        private readonly ITicketRepository _basketRepository;
        private readonly IMediator _mediator;

        public TicketService(ITicketRepository basketRepository, IMediator mediator)
        {
            _basketRepository = basketRepository;
            _mediator = mediator;
        }
    }
}