using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTrainicity.Modules;

namespace XamarinTrainicity.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinishingPage : ContentPage
    {
        public FinishingPage()
        {
            InitializeComponent();
            ProgramSelector programSelector = new ProgramSelector();
            int program = programSelector.SelectProgram();
            switch (program)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
            }
        }
    }
}