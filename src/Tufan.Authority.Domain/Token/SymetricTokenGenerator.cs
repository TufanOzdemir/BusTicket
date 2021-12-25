using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Tufan.Authority.Domain.Model.Entity;
using Tufan.Common.Configuration;

namespace Tufan.Authority.Domain.Token
{
    public class SymetricTokenGenerator : ITokenGenerator
    {
        private readonly IConfigResolver _configResolver;

        public SymetricTokenGenerator(IConfigResolver configResolver)
        {
            _configResolver = configResolver;
        }

        public string GetToken(Session session)
        {
            var authConfig = _configResolver.Resolve<AuthenticationConfig>();
            var symmetricKey = Convert.FromBase64String(authConfig.Secret);
            var tokenHandler = new JwtSecurityTokenHandler();

            var claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.SerialNumber, session.SessionId));
            claims.Add(new Claim(ClaimTypes.Authentication, session.DeviceId));

            var now = DateTime.Now;
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = "Tufan.Authority",
                IssuedAt = now,
                Subject = new ClaimsIdentity(claims),
                Expires = now.AddMinutes(authConfig.ExpireMinutes),
                NotBefore = now,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(symmetricKey), SecurityAlgorithms.HmacSha256),
            };
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(securityToken);

            return token;
        }
    }
}
