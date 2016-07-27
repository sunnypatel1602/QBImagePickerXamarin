using System;
using QBImagePickerBinding;
using UIKit;

namespace Example
{
	public partial class ViewController : UIViewController
	{
		QBImagePickerController imagePickerController;
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			UIButton button = new UIButton()
			{
				Frame = new CoreGraphics.CGRect(100,100,200,100),
			};
			View.Add(button);
			button.SetTitle("Open", UIControlState.Normal);
			button.SetTitleColor(UIColor.Blue, UIControlState.Normal);

			button.TouchUpInside += delegate {
				imagePickerController = new QBImagePickerController();
				imagePickerController.Delegate = new PickerDelegate(imagePickerController);
				imagePickerController.AllowsMultipleSelection = true;
				imagePickerController.MaximumNumberOfSelection = 6;
				imagePickerController.ShowsNumberOfSelectedAssets = true;
				this.PresentViewController(imagePickerController, true, null);
			};


			// Perform any additional setup after loading the view, typically from a nib.
		}

		public class PickerDelegate : QBImagePickerControllerDelegate 
		{
			QBImagePickerController _controller;
			public PickerDelegate(QBImagePickerController controller)
			{
				_controller = controller;
			}
				

			public override void Qb_imagePickerControllerDidCancel(QBImagePickerController imagePickerController)
			{
				_controller.DismissViewController(true, null);
			}
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

