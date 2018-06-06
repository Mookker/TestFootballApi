using MvvmCross.ViewModels;
using TestFootballApi.Core.Models;

namespace TestFootballApi.Core.ViewModels
{
    public class CompetitionDetailsViewModel : MvxViewModel, IMvxViewModel<CompetitionDetailsViewModelArgs>
    {
        private Competition _competition;

        public void Prepare(CompetitionDetailsViewModelArgs parameter)
        {
            Competition = parameter.Competition;
            
        }

        public int NumberOfTeams => Competition.NumberOfTeams;
        public int NumberOfGames => Competition.NumberOfGames;
        public object Caption => Competition.Caption;
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
            }
        }

    }
}