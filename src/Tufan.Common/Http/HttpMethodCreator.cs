using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Tufan.Common.Configuration;
using Tufan.Common.Exception;

namespace Tufan.Common.Http
{
    public class HttpMethodCreator
    {
        private readonly ITokenProvider _token;
        private readonly HttpClient _httpClient;
        private readonly UrlConfig _urlConfig;

        public HttpMethodCreator(ITokenProvider token, HttpClient httpClient, UrlConfig urlConfig)
        {
            _token = token;
            _httpClient = httpClient;
            _urlConfig = urlConfig;
        }

        public async Task<T> Get<T>(string url)
        {
            try
            {
                SetHeader();

                var response = await _httpClient.GetAsync(url);
                var responseReceived = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<T>(responseReceived);
                    return data;
                }
                return default;
            }
            catch (System.Exception ex)
            {
                throw (RestRequestException)ex;
            }
        }

        public async Task<string> Post(string url, object model)
        {
            try
            {
                SetHeader();

                var myContent = JsonConvert.SerializeObject(model);
                var buffer = Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await _httpClient.PostAsync(url, byteContent);
                return await response.Content.ReadAsStringAsync();
            }
            catch (System.Exception ex)
            {
                throw (RestRequestException)ex;
            }
        }

        public async Task<T> Post<T>(string url, object model)
        {
            try
            {
                var responseContent = await Post(url, model);
                var content = JsonConvert.DeserializeObject<T>(responseContent);
                return content;
            }
            catch (System.Exception ex)
            {
                throw (RestRequestException)ex;
            }
        }

        private void SetHeader()
        {
            if (!string.IsNullOrWhiteSpace(_token.GetToken()))
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_token.GetScheme(), _token.GetToken());
        }
    }
}