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
	
			// code courtesy of Werner.schnedl@gmx.ch
	                var transition = CATransition.CreateAnimation ();
	                transition.Duration = 0.25f;
	                transition.Type = CATransition.TransitionPush;
	                transition.Subtype = CATransition.TransitionFromRight;
	
	                SourceViewController.View.Window.Layer.AddAnimation(transition, null);
	                SourceViewController.PresentViewController (DestinationViewController, false, null);
		}
	}
}

