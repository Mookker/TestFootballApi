using System;
using Android.Content;
using Android.Runtime;
using Android.Util;
using MvvmCross.Platforms.Android.Binding.Views;
using TestFootballApi.Droid.Adapters;

namespace TestFootballApi.Droid
{
    public class CompetitionsListView : MvxListView
    {
        public CompetitionsListView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Adapter = new CompetitionsAdapter(context);
        }

        public CompetitionsListView(Context context, IAttributeSet attrs, IMvxAdapter adapter) : base(context, attrs, adapter)
        {
        }

        protected CompetitionsListView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}
