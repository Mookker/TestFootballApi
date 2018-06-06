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
    [Register ("CompetitionsView")]
    partial class CompetitionsView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView Competitions { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Competitions != null) {
                Competitions.Dispose ();
                Competitions = null;
            }
        }
    }
}