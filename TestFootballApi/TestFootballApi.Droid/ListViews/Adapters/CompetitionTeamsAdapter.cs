using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Binding.Views;
using TestFootballApi.Droid.Items;

namespace TestFootballApi.Droid.ListViews.Adapters
{
    public class CompetitionTeamsAdapter : MvxAdapter
    {
        public CompetitionTeamsAdapter(Context context) : base(context)
        {
        }

        protected override IMvxListItemView CreateBindableView(object dataContext, ViewGroup parent, int templateId)
        {
            return new CompetitionTeamListItemView(Context, BindingContext.LayoutInflaterHolder, dataContext, parent,
                templateId);
        }
    }
}