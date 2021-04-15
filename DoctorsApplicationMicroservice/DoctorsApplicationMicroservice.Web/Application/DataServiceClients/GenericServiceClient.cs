using System;
using System.Text;
using System.Text.Json;

namespace DoctorsApplicationMicroservice.Web.Application.DataServiceClients
{
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class GenericServiceClient
    {
        private readonly IHttpClientFactory _clientFactory;

        public GenericServiceClient(IHttpClientFactory clientFactory)
        {
            this._clientFactory = clientFactory;

        }
        public async Task<Stream> GetData(string requestUri)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            request.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            await using var responseStream = await response.Content.ReadAsStreamAsync();
            return responseStream;
        }

        public async void PostData(string url, Object data)
        {
            var json = JsonSerializer.Serialize(data);
            var toSend = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _clientFactory.CreateClient();
            await client.PostAsync(url, toSend);
        }

    }
}