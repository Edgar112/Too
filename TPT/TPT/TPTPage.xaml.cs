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

            AppCenter.Start("7497ed38-bfec-4ac8-aa4c-42c143ae0c71", typeof(Analytics), typeof(Crashes));
        }
    }
}
