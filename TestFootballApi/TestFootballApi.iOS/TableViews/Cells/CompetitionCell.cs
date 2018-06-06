using System;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using TestFootballApi.Core.Models;
using UIKit;

namespace TestFootballApi.iOS.TableViews.Cells
{
    public partial class CompetitionCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("CompetitionCell");
        public static readonly UINib Nib;

        static CompetitionCell()
        {
            Nib = UINib.FromName("CompetitionCell", NSBundle.MainBundle);
        }

        protected CompetitionCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() => {
                var set = this.CreateBindingSet<CompetitionCell, Competition> ();
                set.Bind(Caption).To(item => item.Caption);
                set.Apply();
            });
        }
    }
}
