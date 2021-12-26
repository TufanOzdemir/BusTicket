using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tufan.Web.UI.Models;
using Tufan.Web.UI.Services;

namespace Tufan.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly TicketService _ticketService;

        public HomeController(TicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _ticketService.GetBusLocations();
            var value = data.Select(c=> new BusLocationViewModel() { Keywords = c.Keywords, Id = c.Id, Name = c.Name }).ToList();
            return View(value);
        }
    }
}
