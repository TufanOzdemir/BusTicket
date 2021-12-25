using Tufan.Common.Abstraction;
using Tufan.Web.UI.Adapters;

namespace Tufan.Web.UI.Services
{
    public class TicketService : IDomainService
    {
        private readonly TicketAdapter _ticketAdapter;

        public TicketService(TicketAdapter ticketAdapter)
        {
            _ticketAdapter = ticketAdapter;
        }
    }
}