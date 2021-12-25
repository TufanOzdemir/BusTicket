using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Tufan.Test
{
    public class UrlIntegrationTest
    {
        private readonly TestServer _testServer;

        public UrlIntegrationTest()
        {
            _testServer = HostBuilderService.Instance.Value.TestServer;
        }

        [Theory]
        [InlineData("07f8c750-e086-4412-869b-d804c58d5006", 1, 10, HttpStatusCode.NoContent)]
        [InlineData("07f8c750-e086-4412-869b-d804c58d5006", 2, 10, HttpStatusCode.NoContent)]
        [InlineData("07f8c750-e086-4412-869b-d804c58d5006", 3, 30, HttpStatusCode.Forbidden)]
        [InlineData("07f8c750-e086-4412-869b-d804c58d5006", 4, 9, HttpStatusCode.NoContent)]
        [InlineData("07f8c750-e086-4412-869b-d804c58d5006", 5, 50, HttpStatusCode.NotFound)]
        public async Task Push(string userId, int productId, int count, HttpStatusCode httpStatusCode)
        {
            //var client = _testServer.CreateClient();

            //var basket = new Domain.Model.Entity.Basket() { Count = count, ProductId = productId, UserId = Guid.Parse(userId) };
            //var jsonRequest = new StringContent(JsonConvert.SerializeObject(basket), System.Text.Encoding.UTF8, "application/json");
            //var response = await client.PostAsync("/api/Basket/Push", jsonRequest).ConfigureAwait(false);

            //if (response.StatusCode != httpStatusCode)
            //{
            //    throw new Exception();
            //}
        }

        [Theory]
        [InlineData("2b50d3fb-3776-4c4d-b412-92e04b21d5d6", HttpStatusCode.NotFound)]
        public async Task Search(string userId, HttpStatusCode httpStatusCode)
        {
            var client = _testServer.CreateClient();

            var request = "/api/Basket?request=" + userId;
            var response = await client.GetAsync(request).ConfigureAwait(false);

            if (response.StatusCode != httpStatusCode)
            {
                throw new Exception();
            }
        }
    }
}