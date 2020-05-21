using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using XamarinTrainicity.Data;
using XamarinTrainicity.Modules;

namespace XamarinTrainicity
{
    public class InfoPageViewModel : INotifyPropertyChanged
    {
        private Info info;

        public Info Info
        {
            get { return this.info; }
            set 
            { 
                this.info = value;
                this.RaisePropertyChanged("Info");
            }
        }

        public InfoPageViewModel()
        {
            this.Info = new Info();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
