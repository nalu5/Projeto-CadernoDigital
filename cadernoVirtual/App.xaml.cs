using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cadernoVirtual
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavegationPage (new MainPage());
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
