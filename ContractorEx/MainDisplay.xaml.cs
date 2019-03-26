using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ContractorEx
{
    public partial class MainDisplay : ContentPage
    {
        public MainDisplay()
        {
            InitializeComponent();
            LogoImageSmall.Source = ImageSource.FromResource("ContractorEx.Images.Logo.png");
            backgroundImage.Source = ImageSource.FromResource("ContractorEx.Images.LogoCrop.png");
            ImageRecent1.Source = ImageSource.FromResource("ContractorEx.Images.MineCraftWater.png");
            ImageRecent2.Source = ImageSource.FromResource("ContractorEx.Images.MineCraftWood.png");
            ImageRecent3.Source = ImageSource.FromResource("ContractorEx.Images.MineCraftWoodBlock.jpg");
            ImageRecent4.Source = ImageSource.FromResource("ContractorEx.Images.MineCraftWater.png");
            ImageRecent5.Source = ImageSource.FromResource("ContractorEx.Images.MineCraftWood.png");
            ImageRecent6.Source = ImageSource.FromResource("ContractorEx.Images.MineCraftWoodBlock.jpg");
            ImageRecent7.Source = ImageRecent1.Source;
            ImageRecent8.Source = ImageRecent1.Source;
            ImageRecent9.Source = ImageRecent1.Source;

        }

        void Handle_Activated(object sender, System.EventArgs e)
        {
            DisplayAlert("WARNING", "You pressed the menu", "OK George!!!");
        }
    }
}
