using Xamarin.Forms;
using XamarinTrainicity.Views;

namespace XamarinTrainicity
{
    public partial class App : Application
    {
        public App()
        {


            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            ((NavigationPage)Current.MainPage).BarBackgroundColor = Color.FromHex("#C62F2F");
            ((NavigationPage)Current.MainPage).BarTextColor = Color.White;
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
