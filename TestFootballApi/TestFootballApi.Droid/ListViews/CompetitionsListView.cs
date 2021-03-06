﻿using Android.Content;
using Android.Util;
using MvvmCross.Platforms.Android.Binding.Views;
using TestFootballApi.Droid.ListViews.Adapters;

namespace TestFootballApi.Droid.ListViews
{
    public class CompetitionsListView : MvxListView
    {
        public CompetitionsListView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Adapter = new CompetitionsAdapter(context);
        }
    }
}
