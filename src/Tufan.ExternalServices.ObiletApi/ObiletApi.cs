using System;
using System.Threading.Tasks;
using Tufan.Common.Configuration;
using Tufan.Common.Http;
using Tufan.ExternalServices.ObiletApi.Model;

namespace Tufan.ExternalServices.ObiletApi
{
    public class ObiletApi
    {
        private readonly HttpMethodCreator _httpMethodCreator;
        private readonly UrlConfig _urlConfig;

        public ObiletApi(HttpMethodCreator httpMethodCreator, UrlConfig urlConfig)
        {
            _httpMethodCreator = httpMethodCreator;
            _urlConfig = urlConfig;
        }

        public async Task<SessionResponse> GetSession(SessionRequest request)
        {
            var result = await _httpMethodCreator.Post<Result<SessionResponse>>($"{_urlConfig.ObiletUrl}/api/client/getsession", request);
            return result.Data;
        }
    }
}