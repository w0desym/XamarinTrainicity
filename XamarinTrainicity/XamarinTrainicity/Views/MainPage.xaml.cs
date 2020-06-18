using System;
using Xamarin.Forms;

namespace XamarinTrainicity.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "Trainicity";

            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new InfoPage());
        }
    }
}