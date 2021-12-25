using AutoMapper;
using Tufan.Authority.Domain.Model.Request;

namespace Tufan.Authority.Infrastructure.Mapping
{
    public class SessionMappingProfile : Profile
    {
        public SessionMappingProfile()
        {
            CreateMap<SessionRequest, ExternalServices.ObiletApi.Model.SessionRequest>().ReverseMap();
            CreateMap<ConnectionRequest, ExternalServices.ObiletApi.Model.ConnectionRequest>().ReverseMap();
            CreateMap<BrowserRequest, ExternalServices.ObiletApi.Model.BrowserRequest>().ReverseMap();
        }
    }
}