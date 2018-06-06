using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Binding.Views;
using TestFootballApi.Droid.Items;

namespace TestFootballApi.Droid.Adapters
{
    public class CompetitionsAdapter : MvxAdapter
    {
        public CompetitionsAdapter(Context context) : base(context)
        {
        }

        public CompetitionsAdapter(Context context, IMvxAndroidBindingContext bindingContext) : base(context, bindingContext)
        {
        }

        protected CompetitionsAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        protected override IMvxListItemView CreateBindableView(object dataContext, ViewGroup parent, int templateId)
        {
            return new CompetitionsListItemView(Context, BindingContext.LayoutInflaterHolder, dataContext, parent,
                templateId);
        }
    }
}