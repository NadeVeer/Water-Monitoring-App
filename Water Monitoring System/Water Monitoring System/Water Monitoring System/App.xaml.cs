using System;
using Xamarin.Forms;
namespace XF_Login
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new XF_Login.Pages.LoginPage();
            
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
        private void InitializeComponent()
        {
  
        }
    }
}