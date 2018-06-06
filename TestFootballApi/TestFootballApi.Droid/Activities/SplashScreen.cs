using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;
using TestFootballApi.Core;

namespace TestFootballApi.Droid.Activities
{
    [Activity(
        Label = "Start"
        , MainLauncher = true
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity<MvxAndroidSetup<App>, App>
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}