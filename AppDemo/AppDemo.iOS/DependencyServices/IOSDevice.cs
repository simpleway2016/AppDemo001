using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppDemo.iOS.DependencyServices.IOSDevice))]
namespace AppDemo.iOS.DependencyServices
{
    class IOSDevice : IDevice
    {
        public IOSDevice()
        {
            ScreenWidth = (int)UIScreen.MainScreen.Bounds.Width;
            ScreenHeight = (int)UIScreen.MainScreen.Bounds.Height;
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