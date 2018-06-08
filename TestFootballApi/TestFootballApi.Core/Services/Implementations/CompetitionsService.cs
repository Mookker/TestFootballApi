using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestFootballApi.Core.Helpers.Interfaces;
using TestFootballApi.Core.Models;
using TestFootballApi.Core.Services.Interfaces;

namespace TestFootballApi.Core.Services.Implementations
{
    public class CompetitionsService : ICompetitionsService
    {
        private readonly IHttpHelperService _httpHelperService;
        private const string ApiPath = "http://api.football-data.org/v1";

        public CompetitionsService(IHttpHelperService httpHelperService)
        {
            _httpHelperService = httpHelperService;
            _httpHelperService.AddCustomHeader("X-Auth-Token", "9c53e3f0fb824a9f85959d6f08d10d3f");
        }

        public async Task<List<Competition>> GetCompetitions(string year = null)
        {
            var uri = new StringBuilder($"{ApiPath}/competitions");
            if (!String.IsNullOrWhiteSpace(year))
                uri.Append($"?season={year}");
            var result = await _httpHelperService.GetJSONResponse<List<Competition>>(uri.ToString());

            return result;
        }
    }
}
