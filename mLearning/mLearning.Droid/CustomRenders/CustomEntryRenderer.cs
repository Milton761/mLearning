using mLearning;
using mLearning.CustomRenders;
using mLearning.Droid;
using mLearning.Droid.CustomRenders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]

namespace mLearning.Droid.CustomRenders
{

    public class CustomEntryRenderer : EntryRenderer
    {
        // Override the OnElementChanged method so we can tweak this renderer post-initial setup

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {

            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the textField here!
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
            }
        }
    }
}