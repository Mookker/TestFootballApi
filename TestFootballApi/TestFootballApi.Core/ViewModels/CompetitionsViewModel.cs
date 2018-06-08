using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using TestFootballApi.Core.Models;
using TestFootballApi.Core.Models.Args;
using TestFootballApi.Core.Services.Interfaces;

namespace TestFootballApi.Core.ViewModels
{
    public class CompetitionsViewModel
        : MvxViewModel
    {
        private readonly ICompetitionsService _competitionsService;
        private readonly IMvxNavigationService _navigationService;
        private List<Competition> _competitions;
        private MvxCommand<Competition> _competitionClickedCommand;
        
        public CompetitionsViewModel(ICompetitionsService competitionsService, IMvxNavigationService navigationService)
        {
            _competitionsService = competitionsService;
            _navigationService = navigationService;
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
        
        public IMvxCommand CompetitionClickedCommand {
            get
            {
                return _competitionClickedCommand = _competitionClickedCommand ??
                                                    new MvxCommand<Competition>(competition =>
                                                    {
                                                        _navigationService
                                                            .Navigate<CompetitionDetailsViewModel,
                                                                CompetitionDetailsViewModelArgs>(
                                                                new CompetitionDetailsViewModelArgs
                                                                {
                                                                    Competition = competition
                                                                });
                                                    });
            }
        }
    }
}
