using System.Collections.Generic;
using System.Threading.Tasks;
using TestFootballApi.Core.Models;

namespace TestFootballApi.Core.Services.Interfaces
{
    public interface ITeamsService
    {
        Task<List<Team>> GetCompetitionsTeams(string competitionId);
    }
}