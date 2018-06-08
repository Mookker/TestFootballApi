using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TestFootballApi.Core.Helpers.Interfaces;
using TestFootballApi.Core.Models;
using TestFootballApi.Core.Services.Interfaces;

namespace TestFootballApi.Core.Services.Implementations
{
    public class TeamsService : ITeamsService
    {
        private readonly IHttpHelperService _httpHelperService;
        private const string ApiPath = "http://api.football-data.org/v1";

        public TeamsService(IHttpHelperService httpHelperService)
        {
            _httpHelperService = httpHelperService;
            _httpHelperService.AddCustomHeader("X-Auth-Token", "9c53e3f0fb824a9f85959d6f08d10d3f");
        }
        
        public async Task<List<Team>> GetCompetitionsTeams(string competitionId)
        {
            var uri = new StringBuilder($"{ApiPath}/competitions/{competitionId}/teams");
            var response = await _httpHelperService.GetJSONResponse<TeamsServiceResonse>(uri.ToString());
            
            return response.Teams;
        }

        [DataContract]
        private class TeamsServiceResonse
        {
            [DataMember]
            public List<Team> Teams { get; set; }
        }
    }
}