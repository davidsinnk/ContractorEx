using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace ContractorEx
{
    public partial class SignUpMainPage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {


            await Navigation.PopModalAsync();
        }

        public SignUpMainPage()
        {
            InitializeComponent();


        }

    }
}
