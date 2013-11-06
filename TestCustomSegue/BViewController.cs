using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TestCustomSegue {
	public partial class BViewController : UIViewController {

		// Required by Storyboard runtime when performing the Segue.
		public BViewController (IntPtr pt) : base(pt)
		{
		}

		// Dismiss this view controller (dialog) on command.
		partial void MyDismssButton_TouchUpInside (UIButton sender)
		{
			DismissViewController(true, null);
		}
	}
}

