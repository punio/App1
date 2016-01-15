using System;
using Foundation;
using UIKit;

namespace App1
{
	public partial class ViewController : UIViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var notification = new UILocalNotification();
			notification.FireDate = NSDate.Now.AddSeconds(10);
			notification.TimeZone = NSTimeZone.DefaultTimeZone;
			notification.AlertTitle = "Alert test";
			notification.AlertAction = "Alert action";
			notification.AlertBody = "test alert ";
			notification.SoundName = "default";
			notification.UserInfo = NSDictionary.FromObjectAndKey(new NSString("UserInfo for notification"), new NSString("Notification"));
			UIApplication.SharedApplication.ScheduleLocalNotification(notification);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}