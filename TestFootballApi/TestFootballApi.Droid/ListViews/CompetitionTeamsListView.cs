using Android.Content;
using Android.Util;
using MvvmCross.Platforms.Android.Binding.Views;
using TestFootballApi.Droid.ListViews.Adapters;

namespace TestFootballApi.Droid.ListViews
{
    public class CompetitionTeamsListView : MvxListView
    {
        public CompetitionTeamsListView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Adapter = new CompetitionTeamsAdapter(context);
        }
    }
}
