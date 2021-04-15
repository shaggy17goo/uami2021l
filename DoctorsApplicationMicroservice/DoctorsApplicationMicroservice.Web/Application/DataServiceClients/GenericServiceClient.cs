using System;
using System.Text;
using System.Text.Json;

namespace DoctorsApplicationMicroservice.Web.Application.DataServiceClients
{
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Commands.Commands;

    public class GenericServiceClient
    {
        private readonly IHttpClientFactory _clientFactory;

        public GenericServiceClient(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
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

        public async void PostData(string url, ICommand command)
        {
            var json = JsonSerializer.Serialize(command);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _clientFactory.CreateClient();
            await client.PostAsync(url, data);
        }

    }
}