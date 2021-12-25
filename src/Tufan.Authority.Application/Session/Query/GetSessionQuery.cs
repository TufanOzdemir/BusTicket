using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Tufan.Authority.Domain.Model.Request;
using Tufan.Authority.Domain.Services;

namespace Tufan.Authority.Application.Session.Query
{
    public class GetSessionQuery : SessionRequest, IRequest<Domain.Model.Entity.Session>
    {

    }

    public class GetSessionQueryHandler : IRequestHandler<GetSessionQuery, Domain.Model.Entity.Session>
    {
        private readonly SessionService _sessionService;

        public GetSessionQueryHandler(SessionService sessionService)
        {
            _sessionService = sessionService;
        }

        public Task<Domain.Model.Entity.Session> Handle(GetSessionQuery request, CancellationToken cancellationToken)
        {
            return _sessionService.GetSession(request);
        }
    }
}