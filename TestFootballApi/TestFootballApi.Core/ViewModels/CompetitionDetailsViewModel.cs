using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using TestFootballApi.Core.Models;
using TestFootballApi.Core.Models.Args;

namespace TestFootballApi.Core.ViewModels
{
    public class CompetitionDetailsViewModel : MvxViewModel, IMvxViewModel<CompetitionDetailsViewModelArgs>
    {
        private Competition _competition;
        private readonly IMvxNavigationService _navigationService;
        private MvxCommand _teamsClickedCommand;

        public CompetitionDetailsViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void Prepare(CompetitionDetailsViewModelArgs parameter)
        {
            Competition = parameter.Competition;
            
        }

        public int NumberOfTeams => Competition.NumberOfTeams;
        public int NumberOfGames => Competition.NumberOfGames;
        public string Caption => Competition.Caption;
        public string MatchDayStats => $"{Competition.CurrentMatchday}/{Competition.NumberOfMatchdays}";
        
        public Competition Competition
        {
            get => _competition;
            private set
            {
                _competition = value; 
                RaisePropertyChanged(nameof(Competition));
                RaisePropertyChanged(nameof(NumberOfTeams));
                RaisePropertyChanged(nameof(Caption));
                RaisePropertyChanged(nameof(NumberOfGames));
                RaisePropertyChanged(nameof(MatchDayStats));
            }
        }
        
        public IMvxCommand TeamsClickedCommand {
            get
            {
                return _teamsClickedCommand = _teamsClickedCommand ??
                                                    new MvxCommand(() =>
                                                    {
                                                        _navigationService
                                                            .Navigate<CompetitionTeamsViewModel,
                                                                CompetitionTeamsViewModelArgs>(
                                                                new CompetitionTeamsViewModelArgs
                                                                {
                                                                    CompetitionId = _competition.Id.ToString()
                                                                });
                                                    });
            }
        }

    }
}