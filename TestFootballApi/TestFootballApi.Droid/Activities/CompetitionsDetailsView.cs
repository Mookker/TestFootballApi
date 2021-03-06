﻿using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using TestFootballApi.Core.Models;
using TestFootballApi.Core.ViewModels;
using TestFootballApi.Droid.Items;

namespace TestFootballApi.Droid.Activities
{
    [MvxActivityPresentation]
    [Activity(Label = "Competition Details")]
    public class CompetitionDetailsView : MvxActivity<CompetitionDetailsViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CompetitionDetailsView);
        }
    }
}