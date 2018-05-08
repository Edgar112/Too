using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TPT
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("https://tpt.siseveeb.ee/"));
		}

		void Handle_Clicked_1(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("https://tpt.siseveeb.ee/veebivormid/tunniplaan"));
		}

		void Handle_Clicked_2(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("https://tpt.siseveeb.ee/veebivormid/konsultatsioonid"));
		}

		void Handle_Clicked_3(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("https://tptliveee-my.sharepoint.com/personal/info_tptlive_ee/Documents/WWW/Aasta1718.pdf?slrid=9f42659e-d094-5000-b48c-0c374861e830"));
		}

		void Handle_Clicked_4(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("https://www.tptlive.ee/opilasele/opilasesindus/"));
		}

		void Handle_Clicked_5(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("https://www.tptlive.ee/kool/raamatukogu/"));
		}

		void Handle_Clicked_6(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("https://www.tptlive.ee/kool/opilaskodu/"));
		}

		void Handle_Clicked_7(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("https://www.tptlive.ee/kool/sookla/"));
		}

		void Handle_Clicked_8(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("https://www.tptlive.ee/opilasele/huviringid/"));
		}

		void Handle_Clicked_9(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("https://www.tptlive.ee/oppetoo/oppekorralduseeskiri/"));
		}

		void Handle_Clicked_10(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("https://tptliveee-my.sharepoint.com/personal/info_tptlive_ee/Documents/WWW/OPPEKORRALDUS/Soidukulu%20hyvitamine_2015.pdf?slrid=ba42659e-609c-5000-99ef-818e2960fdc0v"));
		}

		void Handle_Clicked_11(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("https://tptliveee-my.sharepoint.com/personal/info_tptlive_ee/Documents/WWW/OPPEKORRALDUS/Lisa1_soidukulu_avaldus_2015.pdf?slrid=c142659e-906a-5000-99ef-82942cbc1cfa"));
		}

		void Handle_Clicked_12(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("https://tptliveee-my.sharepoint.com/personal/info_tptlive_ee/Documents/WWW/OPPEKORRALDUS/Lisa2_soidukulu_aruanne_2015.pdf?slrid=c542659e-0041-5000-99ef-83128b46f27a"));
		}

		void Handle_Clicked_13(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("https://tptliveee-my.sharepoint.com/personal/info_tptlive_ee/Documents/WWW/OPPEKORRALDUS/Sisekorraeeskiri_2015_eesti.pdf?slrid=cb42659e-c023-5000-d1a2-40e7325fda62"));
		}
    }
}
