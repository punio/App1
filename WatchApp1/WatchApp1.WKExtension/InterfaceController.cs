using System;

using WatchKit;
using Foundation;

namespace WatchApp1.WKExtension
{
	public partial class InterfaceController : WKInterfaceController
	{
		public InterfaceController(IntPtr handle) : base(handle)
		{
		}

		public override void Awake(NSObject context)
		{
			base.Awake(context);

			// Configure interface objects here.
			Console.WriteLine("{0} awake with context", this);
		}

		public override void WillActivate()
		{
			var width = WKInterfaceDevice.CurrentDevice.ScreenBounds.Width;
			var size = width > 136.0 ? "42mm" : "38mm";
			this.label1.SetText($"{width}pixel - {size}");
		}

		public override void DidDeactivate()
		{
			// This method is called when the watch view controller is no longer visible to the user.
			Console.WriteLine("{0} did deactivate", this);
		}

		partial void Button1_Activated() => this.PresentTextInputController(new[] { "Yes", "No", "Maybe" }, WKTextInputMode.Plain, delegate (NSArray results) {
			if (results?.Count > 0)
			{
				WKInterfaceController.OpenParentApplication(new NSDictionary("input", results.GetItem<NSObject>(0).ToString()), (replyInfo, error) =>
				{
					if (error != null)
					{
						this.label1.SetText(error.ToString());
						return;
					}

					var result = ((NSString)replyInfo["result"]).ToString();
					this.label1.SetText(result);
				});
			}
		});
	}
}

