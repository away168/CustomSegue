using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace TestCustomSegue {

	[Register("MySegue")]
	public class MySegue : UIStoryboardSegue {

		public MySegue (IntPtr pt) : base (pt)
		{
		}

		public override void Perform ()
		{
			Console.WriteLine ("MySegue:Perform()");

			SourceViewController.PresentViewController (DestinationViewController, true, null);

		}
	}
}

