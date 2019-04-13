using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppDemo
{
    public partial class App : Application
    {

        static IDevice _CurrentDevice;
        public static IDevice CurrentDevice
        {
            get
            {
                if (_CurrentDevice == null)
                {
                    _CurrentDevice = DependencyService.Get<IDevice>();
                }
                return _CurrentDevice;
            }
        }

        internal static BaseModels.TextResourceModel TextResource = new BaseModels.TextResourceModel();

        public App()
        {
            InitializeComponent();

            TextResource.LoadTextResource("zh-CN");
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
