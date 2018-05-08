using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TPT
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("mailto:info@tptlive.ee")); //ios dont work
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.tptlive.ee"));
        }

        void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/polütehniku"));
        }
    }
}
