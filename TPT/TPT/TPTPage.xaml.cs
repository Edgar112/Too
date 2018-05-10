
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace TPT
{
    public partial class TPTPage : TabbedPage
    {
        public TPTPage()
        {
            InitializeComponent();

            AppCenter.Start("android=0bc8c2ed-9d37-432b-8c87-145f00f05dd4;" + "uwp={Your UWP App secret here};" + "ios={Your iOS App secret here}", typeof(Analytics), typeof(Crashes));
        }
    }
}
