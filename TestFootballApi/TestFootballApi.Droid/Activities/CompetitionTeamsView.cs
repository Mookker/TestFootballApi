using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using TestFootballApi.Core.ViewModels;

namespace TestFootballApi.Droid.Activities
{
    [MvxActivityPresentation]
    [Activity(Label = "Teams list")]
    public class CompetitionTeamsView : MvxActivity<CompetitionTeamsViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CompetitionTeamsView);
        }
    }
}