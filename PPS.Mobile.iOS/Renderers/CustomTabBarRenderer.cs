using System;
using PPS.Mobile.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabBarRenderer))]
namespace PPS.Mobile.iOS.Renderers
{
    public class CustomTabBarRenderer : TabbedRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            if (TabBar?.Items == null)
                return;

            // Go through our elements and change them
            var tabs = Element as TabbedPage;
            if (tabs != null)
            {
                for (int i = 0; i < TabBar.Items.Length; i++)
                    UpdateTabBarItem((UITabBarItem)TabBar.Items[i]);
            }

            base.ViewWillAppear(animated);
        }

        private void UpdateTabBarItem(UITabBarItem item)
        {
            if (item == null)
                return;

            UITextAttributes normalTextAttributes = new UITextAttributes();
            normalTextAttributes.Font = UIFont.FromName("Helvetica-Light", 15.0F); // unselected

            UITabBarItem.Appearance.SetTitleTextAttributes(normalTextAttributes, UIControlState.Normal);
        
                        
            // Moves the titles up just a bit.
            item.TitlePositionAdjustment = new UIOffset(0, -15);
        }
    }
}
