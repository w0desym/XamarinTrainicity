using System;
using System.Collections.Generic;
using System.Text;
using XamarinTrainicity.Data;

namespace XamarinTrainicity.ViewModels
{
    public class InfoPageViewModel
    {
        private Info info;
        
        public Info Info
        {
            get { return this.info; }
            set { this.info = value; }
        }

        public InfoPageViewModel()
        {
            this.info = new Info();
        }
    }
}
