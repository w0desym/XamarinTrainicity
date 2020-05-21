using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTrainicity.Modules;

namespace XamarinTrainicity.Views
{
    public partial class FinishingPage : ContentPage
    {
        int program;
        string fileName;
        public FinishingPage()
        {
               
        }
        public FinishingPage(int weight, int height, int maxPushUps, int maxSquats, int maxPullUps)
        {
            InitializeComponent();
            ProgramSelector programSelector = new ProgramSelector(weight, height, maxPushUps, maxSquats, maxPullUps);
            program = programSelector.SelectProgram();
            switch (program)
            {
                case 1:
                    fileName = "NewbieLowBodyMassIndex.pdf";
                    break;
                case 2:
                    fileName = "NewbieLowBodyMassIndex.pdf";
                    break;
                case 3:
                    fileName = "NewbieLowBodyMassIndex.pdf";
                    break;
                case 4:
                    fileName = "NewbieLowBodyMassIndex.pdf";
                    break;
                case 5:
                    fileName = "NewbieLowBodyMassIndex.pdf";
                    break;
                case 6:
                    fileName = "NewbieLowBodyMassIndex.pdf";
                    break;
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PdfViewer(fileName));
        }
    }
}