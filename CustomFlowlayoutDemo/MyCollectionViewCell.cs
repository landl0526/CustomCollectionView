using System;

using Foundation;
using UIKit;

namespace CustomFlowlayoutDemo
{
    public partial class MyCollectionViewCell : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("MyCollectionViewCell");
        public static readonly UINib Nib;

        static MyCollectionViewCell()
        {
            Nib = UINib.FromName("MyCollectionViewCell", NSBundle.MainBundle);
        }

        protected MyCollectionViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.

            ContentView.BackgroundColor = UIColor.Red;
        }

        private string myStr;
        public string MyStr
        {
            set
            {
                myStr = value;
                MyLabel.Text = myStr;
            }
            get
            {
                return myStr;
            }
        }
    }
}