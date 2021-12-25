using System.Collections.Generic;
using System.Threading.Tasks;
using Tufan.Ticket.Domain.Model.Entity;
using Tufan.Ticket.Domain.Model.Request;

namespace Tufan.Ticket.Domain.Persistance
{
    public interface IBusLocationRepository
    {
        Task<List<BusLocation>> GetBusLocation(GetBusLocationRequest data);
    }
}