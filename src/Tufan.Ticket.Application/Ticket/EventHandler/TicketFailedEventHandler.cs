using Tufan.Ticket.Domain.Model.Events;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Tufan.Ticket.Application.Basket.EventHandler
{
    public class TicketFailedEventHandler : INotificationHandler<TicketFailedEvent>
    {
        private readonly IMediator _mediator;

        public TicketFailedEventHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task Handle(TicketFailedEvent notification, CancellationToken cancellationToken)
        {
            //TO DO
            return Task.CompletedTask;
        }
    }
}
