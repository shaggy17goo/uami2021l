//===============================================================================
//
// PlaZa System Platform
//
//===============================================================================
//
// Warsaw University of Technology
// Computer Networks and Services Division
// Copyright © 2020 PlaZa Creators
// All rights reserved.
//
//===============================================================================

namespace ZsutPw.Patterns.Application.Model
{
  using System;
  using System.Collections.Generic;
  using System.Diagnostics;
  using System.Linq;
  using System.Threading.Tasks;

  using System.Net.Http;
  using System.Text.Json;
    using System.Text;
    using Newtonsoft.Json;

    public class ServiceClient
    {
        private static readonly HttpClient httpClient = new HttpClient();

        private readonly string serviceHost;
        private readonly ushort servicePort;

        public ServiceClient(string serviceHost, int servicePort)
        {
            Debug.Assert(!string.IsNullOrEmpty(serviceHost) && servicePort > 0);

            this.serviceHost = serviceHost;
            this.servicePort = (ushort)servicePort;
        }

        public R CallWebService<R>(HttpMethod httpMethod, string webServiceUri)
        {
            var webServiceCall =  CallWebService(httpMethod, webServiceUri);

            webServiceCall.Wait();

            var jsonResponseContent = webServiceCall.Result;

            var result = ConvertJson<R>(jsonResponseContent);

            return result;
        }

        public async Task<string> CallWebService(HttpMethod httpMethod, string callUri)
        {
            var httpUri = string.Format("http://{0}:{1}/{2}", serviceHost, servicePort, callUri);

            var httpRequestMessage = new HttpRequestMessage(httpMethod, httpUri);

            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage).ConfigureAwait(false);

            httpResponseMessage.EnsureSuccessStatusCode();

            var httpResponseContent = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            return httpResponseContent;
        }
        public async Task<string> CallWebService(HttpMethod httpMethod, string callUri, string myJson)
        {
            var httpUri = string.Format("http://{0}:{1}/{2}", serviceHost, servicePort, callUri);

            var httpRequestMessage = new HttpRequestMessage(httpMethod, httpUri);

            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            httpRequestMessage.Content = new StringContent(myJson, Encoding.UTF8, "application/json");

            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage).ConfigureAwait(false);

            httpResponseMessage.EnsureSuccessStatusCode();

            var httpResponseContent = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            return httpResponseContent;
        }

        private T ConvertJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

    }
}
