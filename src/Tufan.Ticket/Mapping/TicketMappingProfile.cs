using AutoMapper;
using Tufan.Ticket.Application.Journey.Query;
using Tufan.Ticket.Application.Location.Query;
using Tufan.Ticket.Models.Request;

namespace Tufan.Ticket.Mapping
{
    public class TicketMappingProfile : Profile
    {
        public TicketMappingProfile()
        {
            CreateMap<GetBusJourneyRequest, GetBusJourneyQuery>();
            CreateMap<GetBusJourneyRequest, Domain.Model.Request.GetBusJourneyRequest>();
            CreateMap<JourneyDataRequest, Domain.Model.Request.JourneyDataRequest>();

            CreateMap<GetBusLocationRequest, GetBusLocationQuery>();
            CreateMap<GetBusLocationRequest, Domain.Model.Request.GetBusLocationRequest>();
        }
    }
}