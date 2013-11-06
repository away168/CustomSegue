// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace TestCustomSegue
{
	[Register ("BViewController")]
	partial class BViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton MyDismssButton { get; set; }

		[Action ("MyDismssButton_TouchUpInside:")]
		partial void MyDismssButton_TouchUpInside (MonoTouch.UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (MyDismssButton != null) {
				MyDismssButton.Dispose ();
				MyDismssButton = null;
			}
		}
	}
}
