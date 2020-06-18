using Syncfusion.Pdf.Parsing;
using System;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using XamarinTrainicity.Modules;

namespace XamarinTrainicity.Views
{
    public partial class FinishingPage : ContentPage
    {
        int program;
        string name;
        string fileName;
        string path;
        Stream fileStream;

        public FinishingPage()
        {
               
        }

        public FinishingPage(string name, int weight, int height, int maxPushUps, int maxSquats, int maxPullUps)
        {
            InitializeComponent();
            ProgramSelector programSelector = new ProgramSelector(weight, height, maxPushUps, maxSquats, maxPullUps);
            program = programSelector.SelectProgram();
            switch (program)
            {
                case 1:
                    fileName = "NewbieLowBMI.pdf";
                    break;
                case 2:
                    fileName = "BeginnerLowBMI.pdf";
                    break;
                case 3:
                    fileName = "NewbieNormalBMI.pdf";
                    break;
                case 4:
                    fileName = "BeginnerNormalBMI.pdf";
                    break;
                case 5:
                    fileName = "NewbieHighBMI.pdf";
                    break;
                case 6:
                    fileName = "BeginnerHighBMI.pdf";
                    break;
            }
            path = String.Concat("XamarinTrainicity.Assets.", fileName);
            this.name = String.Concat(name, ".pdf");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream(path);
            PdfLoadedDocument loadedDocument = new PdfLoadedDocument(fileStream);
            MemoryStream stream = new MemoryStream();
            loadedDocument.Save(stream);
            loadedDocument.Close(true);
            await DependencyService.Get<ISave>().SaveAndView(name, "application/pdf", stream);
            await Navigation.PushModalAsync(new ThankPage());
        }
    }
}