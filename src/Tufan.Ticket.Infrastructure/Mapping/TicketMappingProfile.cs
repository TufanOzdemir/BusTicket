using AutoMapper;
using Tufan.ExternalServices.ObiletApi.Model;
using Tufan.Ticket.Domain.Model.Entity;
using Tufan.Ticket.Domain.Model.Request;

namespace Tufan.Ticket.Infrastructure.Mapping
{
    public class TicketMappingProfile : Profile
    {
        public TicketMappingProfile()
        {
            CreateMap<GetBusJourneyRequest, BusJourneyRequest>();
            CreateMap<JourneyDataRequest, JourneyRequestData>();
            CreateMap<DeviceSession, DeviceSessionRequest>().ReverseMap();

            CreateMap<BusJourneyResponse, BusJourney>();
            CreateMap<StopResponse, Stop>();
            CreateMap<PolicyResponse, Policy>();
            CreateMap<FeatureResponse, Feature>();
            CreateMap<JourneyResponse, Journey>();

            CreateMap<GetBusLocationRequest, BusLocationRequest>();
            CreateMap<BusLocationResponse, BusLocation>();
            CreateMap<ExternalServices.ObiletApi.Model.GeoLocation, Domain.Model.Entity.GeoLocation>();
        }
    }
}