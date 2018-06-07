using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using TestFootballApi.Core.ViewModels;
using UIKit;

namespace TestFootballApi.iOS
{
    public partial class CompetitionDetailsView :  MvxViewController<CompetitionDetailsViewModel>
    {
        public CompetitionDetailsView() : base("CompetitionDetailsView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            EdgesForExtendedLayout = UIRectEdge.None;
            var set = this.CreateBindingSet<CompetitionDetailsView, CompetitionDetailsViewModel>();
            set.Bind(caption).To(vm => vm.Caption);
            set.Bind(teamsLbl).To(vm => vm.NumberOfTeams);
            set.Bind(gamesLbl).To(vm => vm.NumberOfGames);
            set.Apply();
        }
    }
}

