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
            AppCenter.Start("ios={Your App Secret};android={Your App Secret}", typeof(Analytics), typeof(Crashes));
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
