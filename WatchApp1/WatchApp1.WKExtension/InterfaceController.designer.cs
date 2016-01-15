// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WatchApp1.WKExtension
{
	[Register ("InterfaceController")]
	partial class InterfaceController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceButton button1 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel label1 { get; set; }

		[Action ("Button1_Activated")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void Button1_Activated ();

		void ReleaseDesignerOutlets ()
		{
			if (button1 != null) {
				button1.Dispose ();
				button1 = null;
			}
			if (label1 != null) {
				label1.Dispose ();
				label1 = null;
			}
		}
	}
}
