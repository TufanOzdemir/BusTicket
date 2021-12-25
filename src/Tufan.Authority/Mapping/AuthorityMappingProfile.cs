using AutoMapper;
using Tufan.Authority.Application.Session.Query;
using Tufan.Authority.Domain.Model.Request;

namespace Tufan.Authority.Mapping
{
    public class AuthorityMappingProfile : Profile
    {
        public AuthorityMappingProfile()
        {
            CreateMap<SessionRequest, GetSessionQuery>();
        }
    }
}