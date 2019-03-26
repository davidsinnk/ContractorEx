using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ContractorEx.Modals;



[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ContractorEx
{
    public partial class App : Application
    {

        public  bool _isLoggedIn = false;
        public static User user = new User();

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainDisplay())
            {
                BarBackgroundColor = Color.FromHex("#118760"),
                BarTextColor = Color.White,
                Title = "Hey there GUY"


            };
            //CreatUser();
            //SetIntitialPage();

        }

        public void SetIntitialPage()
        {

            MainPage = (_isLoggedIn) ? MainPage = 
                new MainDisplay() :
                MainPage = new LogIn();

        }



        public static bool IsLoggedIn
        {
            get;
            set;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void CreatUser()
            // this method will pull any existing data that is cached in the app memory
            // that has been stored by a previous user.
            // if none exists, it will simply return an empty object
        {
            user.NameFirst ="Big";
            user.NameLast = "Walt";
            user.AddressEmail = "bigwalt@strong.com";
            user.Password = "1234";

            user.LoggedIn = false;

           //_isLoggedIn = Application.Current.Properties["UserName"] = null ? false : true;


        }

        public static User GetUser
        {
            get => user;
        }
    }

}
