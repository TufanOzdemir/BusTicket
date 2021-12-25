using MediatR;
using System.Threading.Tasks;
using Tufan.Authority.Domain.Model.Entity;
using Tufan.Authority.Domain.Model.Request;
using Tufan.Authority.Domain.Persistance;
using Tufan.Common.Abstraction;

namespace Tufan.Authority.Domain.Services
{
    public class SessionService : IDomainService
    {
        private readonly ISessionRepository _sessionRepository;
        private readonly IMediator _mediator;

        public SessionService(ISessionRepository sessionRepository, IMediator mediator)
        {
            _sessionRepository = sessionRepository;
            _mediator = mediator;
        }

        public Task<Session> GetSession(SessionRequest request)
        {
            return _sessionRepository.GetSession(request);
        }
    }
}