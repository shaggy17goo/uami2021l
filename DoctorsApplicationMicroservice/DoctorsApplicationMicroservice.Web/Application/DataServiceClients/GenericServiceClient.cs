using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace DoctorsApplicationMicroservice.Web.Application.DataServiceClients
{
    public class GenericServiceClient
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly JsonSerializerOptions _options;

        public GenericServiceClient(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
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

        public int PostData(string url, object command)
        {
            var json = JsonSerializer.Serialize(command);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _clientFactory.CreateClient();
            var httpResponse = client.PostAsync(url, data);
            var responseString = httpResponse.Result.Content.ReadAsStringAsync().Result;
            int response;
            try
            {
                response = int.Parse(responseString);
            }
            catch (Exception)
            {
                return -1;
            }
            return response;
        }
    }
}