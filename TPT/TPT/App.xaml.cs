using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace TPT
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TPTPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("ios=21d79627-f736-4a1c-b580-69e70b1b7282;android=ae7cd086-7555-40f2-b0f4-6b0c28000d0f", typeof(Analytics), typeof(Crashes));
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
