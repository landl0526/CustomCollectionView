using CoreGraphics;
using Foundation;
using System;
using UIKit;

namespace CustomFlowlayoutDemo
{
    public partial class ViewController : UIViewController
    {
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.

            LineLayout lineLayout = new LineLayout();

            UICollectionView collectionView = new UICollectionView(View.Bounds, lineLayout);
            View.AddSubview(collectionView);
            collectionView.DataSource = new MyCollectionViewSource();
            collectionView.BackgroundColor = UIColor.White;

            collectionView.RegisterNibForCell(UINib.FromName("MyCollectionViewCell", null), "Cell");
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
    }

    public class MyCollectionViewSource : UICollectionViewDataSource
    {
        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            MyCollectionViewCell cell = collectionView.DequeueReusableCell("Cell", indexPath) as MyCollectionViewCell;

            cell.MyStr = "label" + indexPath.Row;

            return cell;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return 20;
        }       
    }
}