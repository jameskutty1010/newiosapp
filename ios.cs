using System;
using UIKit; namespace HelloWorld.iOS
{
    public class ViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.White;             var label = new UILabel(new CoreGraphics.CGRect(0, 0, View.Bounds.Width, 50));
            label.Text = "Hello, world!";
            label.TextAlignment = UITextAlignment.Center;
            label.Center = View.Center;
            View.AddSubview(label);
        }
    }
}
