
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using TestFootballApi.Core.ViewModels;
using TestFootballApi.iOS.TableViews.Sources;
using UIKit;

namespace TestFootballApi.iOS
{
    public partial class CompetitionsView : MvxViewController<CompetitionsViewModel>
    {
        public CompetitionsView() : base("CompetitionsView", null)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            Title = "Competitions";
            NavigationController.Title = "Competitions";
            NavigationController.NavigationBar.Translucent = false;
            Competitions.ContentInsetAdjustmentBehavior = UIScrollViewContentInsetAdjustmentBehavior.Never;

            await ViewModel.Init();
            var source = new CompetitionsTableViewSource(Competitions);
            Competitions.Source = source;
            var set = this.CreateBindingSet<CompetitionsView, CompetitionsViewModel>();
            set.Bind(source).To(vm => vm.Competitions);
            set.Bind(source).For(s => s.SelectionChangedCommand).To(vm => vm.CompetitionClickedCommand);
            set.Apply();
            Competitions.ReloadData();
        }

    }
}

