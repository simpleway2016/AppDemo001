using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppDemo.Droid.DependencyServices.AndroidDevice))]
namespace AppDemo.Droid.DependencyServices
{
    class AndroidDevice : IDevice
    {
        public AndroidDevice()
        {
            Android.Util.DisplayMetrics dm = new Android.Util.DisplayMetrics();

            var context = (Activity)Forms.Context;

            ((Activity)context).WindowManager.DefaultDisplay.GetMetrics(dm);
            var density = dm.Density;
            ScreenWidth = (int)(dm.WidthPixels / density);
            ScreenHeight = (int)(dm.HeightPixels / density);
        }
        public int ScreenWidth
        {
            get;
            private set;
        }

        public int ScreenHeight
        {
            get;
            private set;
        }
    }
}