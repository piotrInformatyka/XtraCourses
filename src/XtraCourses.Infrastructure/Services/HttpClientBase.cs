using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;

namespace XtraCourses.Infrastructure.services
{
    public abstract class HttpClientBase
    {
        protected readonly RestClient _client;

        protected HttpClientBase()
        {
            _client = new RestClient();
        }

        protected RestRequest GetRequest(string uri)
         => new(GetUri(uri))
            {
                RequestFormat = DataFormat.Json
            };

        protected T HandleResponse<T>(RestResponse response)
        {
            if (response.IsSuccessful)
                return JsonConvert.DeserializeObject<T>(response?.Content ?? "");

            throw new Exception($"Request {response?.Request?.Method} {response?.ResponseUri} failed");
        }

        private static Uri GetUri(string ipAddress) => new(ipAddress);
    }
}
