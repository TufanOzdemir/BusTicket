using FluentValidation;
using Tufan.Ticket.Application.Journey.Query;

namespace Tufan.Ticket.Application.Module.Validation
{
    public class GetBusJourneyQueryValidator : AbstractValidator<GetBusJourneyQuery>
    {
        public GetBusJourneyQueryValidator()
        {
            RuleFor(c => c.Data).NotNull();
        }
    }
}