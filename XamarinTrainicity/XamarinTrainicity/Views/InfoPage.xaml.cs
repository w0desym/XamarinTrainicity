using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTrainicity.Data;
using XamarinTrainicity.Modules;

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
            dataForm.Commit();
            var weight = (dataForm.DataObject as Info).Weight;
            var height = (dataForm.DataObject as Info).Height;
            var maxPushUps = (dataForm.DataObject as Info).MaxPushUps;
            var maxSquats = (dataForm.DataObject as Info).MaxSquats;
            var maxPullUps = (dataForm.DataObject as Info).MaxPullUps;

            await Navigation.PushModalAsync(new FinishingPage(weight, height, maxPushUps, maxSquats, maxPullUps));
        }

    }
}
