using MediatR;
using System.Threading.Tasks;
using Tufan.Authority.Domain.Model.Entity;
using Tufan.Authority.Domain.Model.Request;
using Tufan.Authority.Domain.Persistance;
using Tufan.Authority.Domain.Token;
using Tufan.Common.Abstraction;

namespace Tufan.Authority.Domain.Services
{
    public class SessionService : IDomainService
    {
        private readonly ISessionRepository _sessionRepository;
        private readonly IMediator _mediator;
        private readonly ITokenGenerator _tokenGenerator;

        public SessionService(ISessionRepository sessionRepository, IMediator mediator, ITokenGenerator tokenGenerator)
        {
            _sessionRepository = sessionRepository;
            _mediator = mediator;
            _tokenGenerator = tokenGenerator;
        }

        public async Task<string> GetSession(SessionRequest request)
        {
            var model = await _sessionRepository.GetSession(request);
            return _tokenGenerator.GetToken(model);
        }
    }
}