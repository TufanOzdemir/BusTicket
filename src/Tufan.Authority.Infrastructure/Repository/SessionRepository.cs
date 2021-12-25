using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tufan.Authority.Domain.Model.Entity;
using Tufan.Authority.Domain.Model.Request;
using Tufan.Authority.Domain.Persistance;
using Tufan.ExternalServices.ObiletApi;

namespace Tufan.Authority.Infrastructure.Repository
{
    public class SessionRepository : ISessionRepository
    {
        private readonly ObiletApi _obiletApi;
        private readonly IMapper _mapper;

        public SessionRepository(ObiletApi obiletApi, IMapper mapper)
        {
            _obiletApi = obiletApi;
            _mapper = mapper;
        }

        public async Task<Session> GetSession(SessionRequest sessionRequest)
        {
            var request = _mapper.Map<ExternalServices.ObiletApi.Model.SessionRequest>(sessionRequest);
            var result = await _obiletApi.GetSession(request);
            return _mapper.Map<Session>(result);
        }
    }
}