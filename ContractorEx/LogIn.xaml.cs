using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ContractorEx
{


    public partial class LogIn : ContentPage

    {
    

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if(e.NewTextValue == "bigwalt@strong.com")
            {
                passwordField.Text = "1234567";
            }
        }

        public LogIn()
        {
            InitializeComponent();
            LoadUserInfo();
            backgroundImage.Source = ImageSource.FromResource("ContractorEx.Images.Logo.png");

        }

         void btnLogInClick(object sender, System.EventArgs e)
        {

            emialField.Text = "Fucking right ASSHOLE";
        }

        private void LoadUserInfo()
        {
            emialField.Text = (App.IsLoggedIn) ? "fuck":  "";

        }
    }
}
