using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tufan.Common.Exception;
using Tufan.Ticket.Application.Journey.Query;
using Tufan.Ticket.Domain.Model.Entity;
using Tufan.Ticket.Models.Request;

namespace Tufan.Ticket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(BadRequestErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status403Forbidden)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status404NotFound)]
    public class JourneyController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public JourneyController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<BusJourney>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get([FromBody] GetBusJourneyRequest request)
        {
            var query = _mapper.Map<GetBusJourneyQuery>(request);
            var result = await _mediator.Send(query);
            return result != null && result.Any() ? Ok(result) : (IActionResult)NotFound();
        }
    }
}