using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tufan.Authority.Application.Session.Query;
using Tufan.Authority.Domain.Model.Request;

namespace Tufan.Authority.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public SessionController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Get(SessionRequest sessionRequest)
        {
            var query = _mapper.Map<GetSessionQuery>(sessionRequest);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}