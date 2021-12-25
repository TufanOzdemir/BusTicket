using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Tufan.Authority.Domain.Model.Request;
using Tufan.Authority.Domain.Services;

namespace Tufan.Authority.Application.Session.Query
{
    public class GetSessionQuery : SessionRequest, IRequest<string>
    {

    }

    public class GetSessionQueryHandler : IRequestHandler<GetSessionQuery, string>
    {
        private readonly SessionService _sessionService;

        public GetSessionQueryHandler(SessionService sessionService)
        {
            _sessionService = sessionService;
        }

        public Task<string> Handle(GetSessionQuery request, CancellationToken cancellationToken)
        {
            return _sessionService.GetSession(request);
        }
    }
}