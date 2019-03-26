using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace ContractorEx
{
    public partial class LandingPage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new LogIn());

        }

        public LandingPage()
        {
            InitializeComponent();

            CXLogo.Source = ImageSource.FromResource("ContractorEx.Images.Logo.png");
        }

        async void Handle_Clicked_1(object sender, System.EventArgs e)
        {



            var action = await DisplayActionSheet("What best discribes you?", "Send Me Back!!!", null, "A Licensed Contractor", "An Employee of a Licensed Contractor", "Not a Licensed Contractor");
            var reaction = await DisplayAlert("Please confirm that you are:", action, "Yes I am", "No, just kidding");

            await Navigation.PushModalAsync(new SignUpMainPage());

        }


    }
}
