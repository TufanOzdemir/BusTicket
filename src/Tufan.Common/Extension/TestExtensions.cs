using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Tufan.Common.Extension
{
    public static class TestExtensions
    {
        public static StringContent ObjectToStringContent(this object obj)
        {
            return new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
        }

        public static void ThrowIsNotSuccess(this HttpResponseMessage httpResponseMessage, string location)
        {
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                throw new System.Exception($"{location}Error -> StatusCode: {httpResponseMessage.StatusCode}");
            }
        }
    }
}