namespace ExaminationRoomsSelector.Web.Application.DataServiceClients
{
    using ExaminationRoomsSelector.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Text.Json;
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
    }
}