/// <summary>
/// Custom Segues can be read about here:
/// https://developer.apple.com/library/ios/featuredarticles/ViewControllerPGforiPhoneOS/CreatingCustomSegues/CreatingCustomSegues.html
/// </summary>

using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace TestCustomSegue {
	
	[Register("MySegue")]
	public class MySegue : UIStoryboardSegue {

		// Required by the Storyboard Runtime to instantiate the Segue. 
		public MySegue (IntPtr pt) : base (pt)
		{
		}

		// minimum method to override for a custom segue.
		public override void Perform ()
		{
			Console.WriteLine ("MySegue:Perform()");

			SourceViewController.PresentViewController (DestinationViewController, true, null);

		}
	}
}

