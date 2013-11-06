using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TestCustomSegue {
	public partial class BViewController : UIViewController {

		public BViewController (IntPtr pt) : base(pt)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		partial void MyDismssButton_TouchUpInside (UIButton sender)
		{
			DismissViewController(true, null);
		}
	}
}

