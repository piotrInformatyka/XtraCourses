using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RestSharp;
using XtraCourses.Infrastructure.Models;

namespace XtraCourses.Infrastructure.services
{
    public class XtraDataClient : HttpClientBase
    {
        private readonly string _apiUrl;

        public XtraDataClient(IConfiguration configuration)
        {
            _apiUrl = configuration["XtraDataUrl"];
        }

        public async Task<IEnumerable<XtraResponseModel>> GetProjectsData()
        {
            var request = GetRequest(_apiUrl);
            
            var response = await _client.GetAsync(request);
            var projects = HandleResponse<IEnumerable<XtraResponseModel>>(response);

            return projects;
        }
    }
}
