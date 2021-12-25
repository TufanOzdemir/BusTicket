using Tufan.Ticket.Domain.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Tufan.Ticket.Application.Module.Command
{
    public class TicketCommand : IRequest<Unit>
    {
    }

    public class DiscardBasketCommandHandler : IRequestHandler<TicketCommand, Unit>
    {
        public async Task<Unit> Handle(TicketCommand request, CancellationToken cancellationToken)
        {
            return Unit.Value;
        }
    }
}