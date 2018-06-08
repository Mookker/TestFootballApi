using Android.Content;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Binding.Views;
using TestFootballApi.Core.Models;

namespace TestFootballApi.Droid.Items
{
    public class CompetitionTeamListItemView : MvxListItemView
    {
        public CompetitionTeamListItemView(Context context, IMvxLayoutInflaterHolder layoutInflaterHolder,
            object dataContext, ViewGroup parent, int templateId) : base(context, layoutInflaterHolder, dataContext,
            parent, templateId)
        {
            var teamName = Content.FindViewById<TextView>(Resource.Id.teamName);
            var set = this.CreateBindingSet<CompetitionTeamListItemView, Team>();
            set.Bind(teamName).To(vm => vm.Name);
            set.Apply();
        }
    }
}