using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;


using Xamarin.Forms;

namespace DroneLander
{
    public partial class App : Application
    {
        public static MainViewModel ViewModel { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DroneLander.MainPage());
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

        protected override void OnLaunch()
        {
            MobileCenter.Start("6ff0692a-f229-4976-b403-c73823306304", typeof(Analytics));
        }
    }
}
