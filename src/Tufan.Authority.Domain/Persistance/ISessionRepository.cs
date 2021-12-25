using System.Threading.Tasks;
using Tufan.Authority.Domain.Model.Entity;
using Tufan.Authority.Domain.Model.Request;

namespace Tufan.Authority.Domain.Persistance
{
    public interface ISessionRepository
    {
        Task<Session> GetSession(SessionRequest sessionRequest);
    }
}