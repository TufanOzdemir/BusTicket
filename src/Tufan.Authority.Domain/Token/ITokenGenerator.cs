using Tufan.Authority.Domain.Model.Entity;

namespace Tufan.Authority.Domain.Token
{
    public interface ITokenGenerator
    {
        public string GetToken(Session session);
    }
}