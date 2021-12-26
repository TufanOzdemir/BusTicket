using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tufan.Web.UI.Services;

namespace Tufan.Web.UI.Controllers
{
    public class JourneyController : Controller
    {
        private readonly TicketService _ticketService;

        public JourneyController(TicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public async Task<IActionResult> Index(int startPoint, int endPoint, string date)
        {
            var journeys = await _ticketService.GetBusJourneys(startPoint, endPoint, date);
            return View(journeys);
        }
    }
}