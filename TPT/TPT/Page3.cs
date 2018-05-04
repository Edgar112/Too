using System;

using Xamarin.Forms;

namespace TPT
{
    public class Page3 : ContentPage
    {
        public Page3()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

