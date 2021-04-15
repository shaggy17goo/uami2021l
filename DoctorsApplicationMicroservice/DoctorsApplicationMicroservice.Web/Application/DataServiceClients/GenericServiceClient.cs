using System;
using System.Text;
using System.Text.Json;

namespace DoctorsApplicationMicroservice.Web.Application.DataServiceClients
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Commands.Commands;
    using Dtos;

    public class GenericServiceClient
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly JsonSerializerOptions _options;

        public GenericServiceClient(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
        }
        public async Task<T> GetData<T>(string requestUri)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            request.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            await using var responseStream = await response.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<T>(responseStream, _options);
        }

        public async void PostData(string url, object command)
        {
            var json = JsonSerializer.Serialize(command);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _clientFactory.CreateClient();
            await client.PostAsync(url, data);
        }

    }
}