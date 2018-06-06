using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestFootballApi.Core.Models;

namespace TestFootballApi.Core.Services.Interfaces
{
    public interface ICompetitionsService
    {
        Task<List<Competition>> GetCompetitions(string year = null);
    }
}
