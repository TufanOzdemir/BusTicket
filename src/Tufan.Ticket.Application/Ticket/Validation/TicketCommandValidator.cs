using Tufan.Ticket.Application.Module.Command;
using FluentValidation;

namespace Tufan.Ticket.Application.Module.Validation
{
    public class TicketCommandValidator : AbstractValidator<TicketCommand>
    {
        public TicketCommandValidator()
        {
            //RuleFor(c => c.Id).NotEmpty().NotNull();
        }
    }
}