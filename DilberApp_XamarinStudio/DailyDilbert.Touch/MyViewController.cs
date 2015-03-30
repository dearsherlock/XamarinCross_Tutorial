using System;
using UIKit;
using CoreGraphics;
using Cirrious.MvvmCross.Touch.Views;


//
using DailyDilbert.Core.ViewModels;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;

namespace DailyDilbert.Touch
{
	public class MyViewController :MvxViewController //UIViewController
    {
        UIButton button;
        int numClicks = 0;
        float buttonWidth = 200;
        float buttonHeight = 50;

        public MyViewController()
        {
        }
		/*
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.Frame = (CGRect)UIScreen.MainScreen.Bounds;
            View.BackgroundColor = UIColor.White;
            View.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;

            button = UIButton.FromType(UIButtonType.RoundedRect);

            button.Frame = new CGRect(
(CGRect)                View.Frame.Width / 2 - buttonWidth / 2,
(CGRect)                View.Frame.Height / 2 - buttonHeight / 2,
                buttonWidth,
                buttonHeight);

            button.SetTitle("Click me", UIControlState.Normal);

            button.TouchUpInside += (object sender, EventArgs e) =>
            {
                button.SetTitle(String.Format("clicked {0} times", numClicks++), UIControlState.Normal);
            };
*/
		/*
            button.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleTopMargin |
                UIViewAutoresizing.FlexibleBottomMargin;

            View.AddSubview(button);
        }*/
		public override void ViewDidLoad()
		{
			//View = new UniversalView();

			base.ViewDidLoad();
		var uiLabel = new UILabel(new CGRect(0, 0, 320, 100));
			View.AddSubview(uiLabel);

			this.CreateBinding(uiLabel).To<FirstViewModel>(vm => vm.Hello).Apply();

			// Perform any additional setup after loading the view
		}

    }
}

