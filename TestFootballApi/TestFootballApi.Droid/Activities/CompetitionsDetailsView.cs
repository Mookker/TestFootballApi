using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using TestFootballApi.Core.Models;
using TestFootballApi.Core.ViewModels;
using TestFootballApi.Droid.Items;

namespace TestFootballApi.Droid.Activities
{
    [MvxActivityPresentation]
    [Activity]
    public class CompetitionDetailsView : MvxActivity
    {
        private CompetitionDetailsViewModel CustomViewModel => ViewModel as CompetitionDetailsViewModel;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CompetitionDetailsView);
            Title = CustomViewModel.Competition.Caption;
            
            var numberOfGamesText = FindViewById<TextView>(Resource.Id.numberOfGames);
            var numberOfTeamsText = FindViewById<TextView>(Resource.Id.numberOfTeams);
            var caption = FindViewById<TextView>(Resource.Id.caption);
            var numberOfMatchDays = FindViewById<TextView>(Resource.Id.numberOfMatchDays);

            var set = this.CreateBindingSet<CompetitionDetailsView, CompetitionDetailsViewModel>();
            set.Bind(numberOfGamesText).To(vm => vm.NumberOfGames);
            set.Bind(numberOfTeamsText).To(vm => vm.NumberOfTeams);
            set.Bind(caption).To(vm => vm.Caption);
            set.Bind(numberOfMatchDays).To(vm => vm.MatchDayStats);
            set.Apply();
        }
    }
}