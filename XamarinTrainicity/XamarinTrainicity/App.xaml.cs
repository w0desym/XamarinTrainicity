using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTrainicity.Views;

namespace XamarinTrainicity
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjYwMDczQDMxMzgyZTMxMmUzMEh1Sjl0V0Z6Ulg1Z0EyVkFZbjN1T3owcDRERGYzMGdoM3F6MzlHWHhFbEk9");

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
