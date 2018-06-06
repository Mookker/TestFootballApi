using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using TestFootballApi.Core.Models;
using TestFootballApi.Core.Services.Interfaces;

namespace TestFootballApi.Core.ViewModels
{
    public class CompetitionsViewModel
        : MvxViewModel
    {
        private readonly ICompetitionsService _competitionsService;
        private List<Competition> _competitions;

        public CompetitionsViewModel(ICompetitionsService competitionsService)
        {
            _competitionsService = competitionsService;
            Init();
        }

        public List<Competition> Competitions
        {
            get => _competitions;
            private set 
            { 
                _competitions = value;
                RaisePropertyChanged(nameof(Competitions));
            }
        }

        public async Task Init()
        {
            Competitions = await _competitionsService.GetCompetitions();
        }
    }
}
