using System;
using PPS.Mobile.Controls;
using PPS.Mobile.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FontAwesomeLabel), typeof(FontAwesomeLabelRenderer))]
namespace PPS.Mobile.Droid.Renderers
{

    public class FontAwesomeLabelRenderer : LabelRenderer
    {
        /// <summary>
        /// Raises the element changed event.
        /// </summary>
        /// <param name="e">E.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
                return;

            var typeface = Typeface.CreateFromAsset(Forms.Context.Assets, "Fonts/FontAwesome.ttf");
            Control.SetTypeface(typeface, TypefaceStyle.Normal);

        }
    }
}


