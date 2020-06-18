using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinTrainicity.Data;

namespace XamarinTrainicity.Views
{
    public partial class InfoPage : ContentPage
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            createPlan.IsEnabled = false;
            dataForm.Commit();
            var name = (dataForm.DataObject as Info).Name;
            var weight = (dataForm.DataObject as Info).Weight;
            var height = (dataForm.DataObject as Info).Height;
            var maxPushUps = (dataForm.DataObject as Info).MaxPushUps;
            var maxSquats = (dataForm.DataObject as Info).MaxSquats;
            var maxPullUps = (dataForm.DataObject as Info).MaxPullUps;

            await Task.Delay(4000);
            await Navigation.PushModalAsync(new FinishingPage(name, weight, height, maxPushUps, maxSquats, maxPullUps));
        }

    }
}
