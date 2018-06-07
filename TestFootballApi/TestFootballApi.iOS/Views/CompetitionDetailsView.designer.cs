// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TestFootballApi.iOS
{
    [Register ("CompetitionDetailsView")]
    partial class CompetitionDetailsView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel caption { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel gamesLbl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel teamsLbl { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (caption != null) {
                caption.Dispose ();
                caption = null;
            }

            if (gamesLbl != null) {
                gamesLbl.Dispose ();
                gamesLbl = null;
            }

            if (teamsLbl != null) {
                teamsLbl.Dispose ();
                teamsLbl = null;
            }
        }
    }
}