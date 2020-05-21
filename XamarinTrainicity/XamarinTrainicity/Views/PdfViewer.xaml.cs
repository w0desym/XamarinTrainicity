using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTrainicity.Views
{
    public sealed partial class PdfViewer : ContentPage
    {
        string path;
        Stream fileStream;
        public PdfViewer(string fileName)
        {
            path = String.Concat("XamarinTrainicity.Assets.", fileName);
            Title = "File Viewer";
            this.InitializeComponent();
        }
        public PdfViewer()
        {

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream(path);
            pdfViewerControl.LoadDocument(fileStream);
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            pdfViewerControl.Unload();
        }
    }
}