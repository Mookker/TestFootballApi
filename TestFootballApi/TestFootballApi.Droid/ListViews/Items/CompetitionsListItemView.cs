using Android.Content;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Binding.Views;
using TestFootballApi.Core.Models;

namespace TestFootballApi.Droid.Items
{
    public class CompetitionsListItemView : MvxListItemView
    {
        public CompetitionsListItemView(Context context, IMvxLayoutInflaterHolder layoutInflaterHolder,
            object dataContext, ViewGroup parent, int templateId) : base(context, layoutInflaterHolder, dataContext,
            parent, templateId)
        {
            var control = Content.FindViewById<TextView>(Resource.Id.caption);
            var set = this.CreateBindingSet<CompetitionsListItemView, Competition>();
            set.Bind(control).To(vm => vm.Caption);
            set.Apply();
        }
    }
}