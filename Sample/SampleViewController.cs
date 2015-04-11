using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace Sample
{
    public partial class SampleViewController : UIViewController
    {
        public SampleViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
			
            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			
            // Perform any additional setup after loading the view, typically from a nib.
            var fpv = new FingerPrintView.CTFingerPrintAnimatedView();
            fpv.Frame = new CoreGraphics.CGRect(0, 0, 100, 100);

            fpv.TintColor = UIColor.Blue;
            fpv.StartAnimation(FingerPrintView.CTFingerPrintAnimationMode.Random);
            this.View.Add(fpv);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}

