using Foundation;
using MvvmCross.Platforms.Ios.Binding.Views;
using UIKit;

namespace TestFootballApi.iOS.TableViews.Sources
{
    public class CompetitionsTableViewSource : MvxSimpleTableViewSource
    {
        public CompetitionsTableViewSource(UITableView tableView)
            : base(tableView, "CompetitionCell", "CompetitionCell")
        {
            tableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;
        }
        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath,
            object item)
        {
            return TableView.DequeueReusableCell("CompetitionCell", indexPath);
        }
    }
}