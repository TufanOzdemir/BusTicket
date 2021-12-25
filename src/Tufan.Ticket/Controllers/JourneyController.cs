using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Tufan.Ticket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JourneyController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public JourneyController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }
    }
}