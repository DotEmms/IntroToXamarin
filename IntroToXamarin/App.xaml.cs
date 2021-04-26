using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroToXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()); //navigation is needed to switch pages!!
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
