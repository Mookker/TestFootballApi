using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using TestFootballApi.Core.ViewModels;

namespace TestFootballApi.Droid.Activities
{
    [MvxActivityPresentation]
    [Activity(Label = "Competitions")]
    public class CompetitionsView : MvxActivity<CompetitionsViewModel>
    {

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CompetitionsView);

            await ViewModel.Init();
        }
        
        
    }
}