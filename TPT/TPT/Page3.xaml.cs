using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TPT
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
			InitializeComponent();
			Browser.Source = "https://tpt.siseveeb.ee/veebivormid/tunniplaan";
        }

        private void backClicked(object sender, EventArgs e)
        {
            // Check to see if there is anywhere to go back to
            if (Browser.CanGoBack)
            {
                Browser.GoBack();
            }
        }

		private void forwardClicked(object sender, EventArgs e)
		{
			if (Browser.CanGoForward)
			{
				Browser.GoForward();
			}
		}
    }
}
