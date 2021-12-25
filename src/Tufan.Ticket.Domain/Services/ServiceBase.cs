using Tufan.Common.Authentication;
using Tufan.Ticket.Domain.Model.Request;

namespace Tufan.Ticket.Domain.Services
{
    public class ServiceBase
    {
        private readonly IDomainPrincipal _domainPrincipal;

        public ServiceBase(IDomainPrincipal domainPrincipal)
        {
            _domainPrincipal = domainPrincipal;
        }

        protected DeviceSessionRequest FillRequestModel()
        {
            return new DeviceSessionRequest()
            {
                DeviceId = _domainPrincipal.DeviceId,
                SessionId = _domainPrincipal.SessionId
            };
        }
    }
}