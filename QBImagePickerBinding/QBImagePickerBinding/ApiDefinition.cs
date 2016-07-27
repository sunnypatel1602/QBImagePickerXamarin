using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using Photos;

namespace QBImagePickerBinding
{
	// @interface QBAlbumCell : UITableViewCell
	[BaseType(typeof(UITableViewCell))]
	interface QBAlbumCell
	{
		// @property (nonatomic, weak) UIImageView * _Nullable imageView1 __attribute__((iboutlet));
		[NullAllowed, Export("imageView1", ArgumentSemantic.Weak)]
		UIImageView ImageView1 { get; set; }

		// @property (nonatomic, weak) UIImageView * _Nullable imageView2 __attribute__((iboutlet));
		[NullAllowed, Export("imageView2", ArgumentSemantic.Weak)]
		UIImageView ImageView2 { get; set; }

		// @property (nonatomic, weak) UIImageView * _Nullable imageView3 __attribute__((iboutlet));
		[NullAllowed, Export("imageView3", ArgumentSemantic.Weak)]
		UIImageView ImageView3 { get; set; }

		// @property (nonatomic, weak) UILabel * _Nullable titleLabel __attribute__((iboutlet));
		[NullAllowed, Export("titleLabel", ArgumentSemantic.Weak)]
		UILabel TitleLabel { get; set; }

		// @property (nonatomic, weak) UILabel * _Nullable countLabel __attribute__((iboutlet));
		[NullAllowed, Export("countLabel", ArgumentSemantic.Weak)]
		UILabel CountLabel { get; set; }

		// @property (assign, nonatomic) CGFloat borderWidth;
		[Export("borderWidth")]
		nfloat BorderWidth { get; set; }
	}

	// @interface QBAlbumsViewController : UITableViewController
	[BaseType(typeof(UITableViewController))]
	interface QBAlbumsViewController
	{
		// @property (nonatomic, weak) QBImagePickerController * _Nullable imagePickerController;
		[NullAllowed, Export("imagePickerController", ArgumentSemantic.Weak)]
		QBImagePickerController ImagePickerController { get; set; }
	}

	// @interface QBAssetCell : UICollectionViewCell
	[BaseType(typeof(UICollectionViewCell))]
	interface QBAssetCell
	{
		// @property (nonatomic, weak) UIImageView * _Nullable imageView __attribute__((iboutlet));
		[NullAllowed, Export("imageView", ArgumentSemantic.Weak)]
		UIImageView ImageView { get; set; }

		// @property (nonatomic, weak) QBVideoIndicatorView * _Nullable videoIndicatorView __attribute__((iboutlet));
		[NullAllowed, Export("videoIndicatorView", ArgumentSemantic.Weak)]
		QBVideoIndicatorView VideoIndicatorView { get; set; }

		// @property (assign, nonatomic) BOOL showsOverlayViewWhenSelected;
		[Export("showsOverlayViewWhenSelected")]
		bool ShowsOverlayViewWhenSelected { get; set; }
	}

	// @interface QBAssetsViewController : UICollectionViewController
	[BaseType(typeof(UICollectionViewController))]
	interface QBAssetsViewController
	{
		// @property (nonatomic, weak) QBImagePickerController * _Nullable imagePickerController;
		[NullAllowed, Export("imagePickerController", ArgumentSemantic.Weak)]
		QBImagePickerController ImagePickerController { get; set; }

		// @property (nonatomic, strong) PHAssetCollection * assetCollection;
		[Export("assetCollection", ArgumentSemantic.Strong)]
		PHAssetCollection AssetCollection { get; set; }
	}

	// @interface QBCheckmarkView : UIView
	[BaseType(typeof(UIView))]
	interface QBCheckmarkView
	{
		// @property (assign, nonatomic) CGFloat borderWidth;
		[Export("borderWidth")]
		nfloat BorderWidth { get; set; }

		// @property (assign, nonatomic) CGFloat checkmarkLineWidth;
		[Export("checkmarkLineWidth")]
		nfloat CheckmarkLineWidth { get; set; }

		// @property (nonatomic, strong) UIColor * borderColor;
		[Export("borderColor", ArgumentSemantic.Strong)]
		UIColor BorderColor { get; set; }

		// @property (nonatomic, strong) UIColor * bodyColor;
		[Export("bodyColor", ArgumentSemantic.Strong)]
		UIColor BodyColor { get; set; }

		// @property (nonatomic, strong) UIColor * checkmarkColor;
		[Export("checkmarkColor", ArgumentSemantic.Strong)]
		UIColor CheckmarkColor { get; set; }
	}

	[Static]
	partial interface Constants
	{
		// extern double QBImagePickerVersionNumber;
		//[Field("QBImagePickerVersionNumber", "__Internal")]
		//double QBImagePickerVersionNumber { get; }

		// extern const unsigned char [] QBImagePickerVersionString;
		//[Field("QBImagePickerVersionString", "__Internal")]
		//char[] QBImagePickerVersionString { get; }
	}

	// @protocol QBImagePickerControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface QBImagePickerControllerDelegate
	{
		// @optional -(void)qb_imagePickerController:(QBImagePickerController *)imagePickerController didFinishPickingAssets:(NSArray *)assets;
		[Export("qb_imagePickerController:didFinishPickingAssets:")]
		void Qb_imagePickerController(QBImagePickerController imagePickerController, NSObject[] assets);

		// @optional -(void)qb_imagePickerControllerDidCancel:(QBImagePickerController *)imagePickerController;
		[Export("qb_imagePickerControllerDidCancel:")]
		void Qb_imagePickerControllerDidCancel(QBImagePickerController imagePickerController);

		// @optional -(BOOL)qb_imagePickerController:(QBImagePickerController *)imagePickerController shouldSelectAsset:(PHAsset *)asset;
		[Export("qb_imagePickerController:shouldSelectAsset:")]
		bool Qb_imagePickerControllerShouldSelectAsset(QBImagePickerController imagePickerController, PHAsset asset);

		// @optional -(void)qb_imagePickerController:(QBImagePickerController *)imagePickerController didSelectAsset:(PHAsset *)asset;
		[Export("qb_imagePickerController:didSelectAsset:")]
		void Qb_imagePickerControllerDidSelectAsset(QBImagePickerController imagePickerController, PHAsset asset);

		//// @optional -(void)qb_imagePickerController:(QBImagePickerController *)imagePickerController didDeselectAsset:(PHAsset *)asset;
		[Export("qb_imagePickerController:didDeselectAsset:")]
		void Qb_imagePickerControllerDidDeselectAsset(QBImagePickerController imagePickerController, PHAsset asset);
	}

	// @interface QBImagePickerController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface QBImagePickerController
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		QBImagePickerControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<QBImagePickerControllerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, strong) NSMutableOrderedSet * selectedAssets;
		[Export("selectedAssets", ArgumentSemantic.Strong)]
		NSMutableOrderedSet SelectedAssets { get; }

		// @property (copy, nonatomic) NSArray * assetCollectionSubtypes;
		[Export("assetCollectionSubtypes", ArgumentSemantic.Copy)]
		NSObject[] AssetCollectionSubtypes { get; set; }

		// @property (assign, nonatomic) QBImagePickerMediaType mediaType;
		[Export("mediaType", ArgumentSemantic.Assign)]
		QBImagePickerMediaType MediaType { get; set; }

		// @property (assign, nonatomic) BOOL allowsMultipleSelection;
		[Export("allowsMultipleSelection")]
		bool AllowsMultipleSelection { get; set; }

		// @property (assign, nonatomic) NSUInteger minimumNumberOfSelection;
		[Export("minimumNumberOfSelection")]
		nuint MinimumNumberOfSelection { get; set; }

		// @property (assign, nonatomic) NSUInteger maximumNumberOfSelection;
		[Export("maximumNumberOfSelection")]
		nuint MaximumNumberOfSelection { get; set; }

		// @property (copy, nonatomic) NSString * prompt;
		[Export("prompt")]
		string Prompt { get; set; }

		// @property (assign, nonatomic) BOOL showsNumberOfSelectedAssets;
		[Export("showsNumberOfSelectedAssets")]
		bool ShowsNumberOfSelectedAssets { get; set; }

		// @property (assign, nonatomic) NSUInteger numberOfColumnsInPortrait;
		[Export("numberOfColumnsInPortrait")]
		nuint NumberOfColumnsInPortrait { get; set; }

		// @property (assign, nonatomic) NSUInteger numberOfColumnsInLandscape;
		[Export("numberOfColumnsInLandscape")]
		nuint NumberOfColumnsInLandscape { get; set; }
	}

	// @interface QBSlomoIconView : UIView
	[BaseType(typeof(UIView))]
	interface QBSlomoIconView
	{
		// @property (nonatomic, strong) UIColor * iconColor;
		[Export("iconColor", ArgumentSemantic.Strong)]
		UIColor IconColor { get; set; }
	}

	// @interface QBVideoIconView : UIView
	[BaseType(typeof(UIView))]
	interface QBVideoIconView
	{
		// @property (nonatomic, strong) UIColor * iconColor;
		[Export("iconColor", ArgumentSemantic.Strong)]
		UIColor IconColor { get; set; }
	}

	// @interface QBVideoIndicatorView : UIView
	[BaseType(typeof(UIView))]
	interface QBVideoIndicatorView
	{
		// @property (nonatomic, weak) UILabel * _Nullable timeLabel __attribute__((iboutlet));
		[NullAllowed, Export("timeLabel", ArgumentSemantic.Weak)]
		UILabel TimeLabel { get; set; }

		// @property (nonatomic, weak) QBVideoIconView * _Nullable videoIcon __attribute__((iboutlet));
		[NullAllowed, Export("videoIcon", ArgumentSemantic.Weak)]
		QBVideoIconView VideoIcon { get; set; }

		// @property (nonatomic, weak) QBSlomoIconView * _Nullable slomoIcon __attribute__((iboutlet));
		[NullAllowed, Export("slomoIcon", ArgumentSemantic.Weak)]
		QBSlomoIconView SlomoIcon { get; set; }
	}

}

