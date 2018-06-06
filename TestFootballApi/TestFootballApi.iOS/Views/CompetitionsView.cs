
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using TestFootballApi.Core.ViewModels;
using TestFootballApi.iOS.TableViews.Sources;

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
            await ViewModel.Init();

            var source = new CompetitionsTableViewSource(Competitions);
            
            
            Competitions.Source = source;

            var set = this.CreateBindingSet<CompetitionsView, CompetitionsViewModel>();
            set.Bind(source).To(vm => vm.Competitions);
            set.Apply();
            Competitions.ReloadData();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

