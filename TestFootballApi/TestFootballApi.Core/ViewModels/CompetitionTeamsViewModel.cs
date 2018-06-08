using System.Collections.Generic;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using TestFootballApi.Core.Models;
using TestFootballApi.Core.Models.Args;
using TestFootballApi.Core.Services.Interfaces;

namespace TestFootballApi.Core.ViewModels
{
    public class CompetitionTeamsViewModel : MvxViewModel, IMvxViewModel<CompetitionTeamsViewModelArgs>
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly ITeamsService _teamsService;
        private List<Team> _teams;
        
        public CompetitionTeamsViewModel(IMvxNavigationService navigationService, ITeamsService teamsService)
        {
            _navigationService = navigationService;
            _teamsService = teamsService;
        }

        public List<Team> Teams
        {
            get => _teams;
            set
            {
                _teams = value;
                RaisePropertyChanged(nameof(Teams));
            }
        }

        public async void Prepare(CompetitionTeamsViewModelArgs args)
        {
            Teams = await _teamsService.GetCompetitionsTeams(args.CompetitionId);
        }
    }
}