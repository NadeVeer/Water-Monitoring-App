using System;
using Water_Monitoring_System.Services;
using Water_Monitoring_System.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Water_Monitoring_System
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
