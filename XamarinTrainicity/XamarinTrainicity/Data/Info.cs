using System;
using Syncfusion.XForms.DataForm;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Essentials;
using System.Collections;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace XamarinTrainicity.Data
{
    public class Info : INotifyPropertyChanged
    {
        #region Fields

        private string name;
        private int age;
        private int weight;
        private int height;
        private int maxPushUps;
        private int maxSquats;
        private int maxPullUps;
        //private string goal;

        #endregion

        #region Constructors

        public Info()
        {

        }

        #endregion

        #region Properties

        [Required(AllowEmptyStrings = false, ErrorMessage = "Should not be empty.")]
        //[DisplayOptions(ValidMessage = "All good.")]
        [StringLength(15, ErrorMessage = "Name should not exceed 15 characters")]
        [Display(Name = "Name")]
        [MinLength(4, ErrorMessage = "Name should be longer")]
        public string Name
        {
            get { return this.name; }
            set 
            { 
                this.name = value;
                this.RaisePropertyChanged("Name");
            }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Should not be empty.")]
        //[DisplayOptions(ValidMessage = "All good.")]
        [Display(Name = "Age")]
        [Range(15, 40, ErrorMessage = "This app is for people from 15 to 40 years old.")]
        public int Age
        {
            get { return this.age; }
            set 
            { 
                this.age = value;
                this.RaisePropertyChanged("BirthDate");
            }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Should not be empty.")]
        [Display(Name = "Weight, kg")]
        [Range(40, 150, ErrorMessage = "Should be higher than 40.")]
        public int Weight
        {
            get { return this.weight; }
            set 
            { 
                this.weight = value;
                this.RaisePropertyChanged("Weight");
            }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Should not be empty.")]
        [Display(Name = "Height, cm")]
        [Range(140, 220, ErrorMessage = "Should be higher than 140.")]
        public int Height
        {
            get { return this.height; }
            set 
            { 
                this.height = value;
                this.RaisePropertyChanged("Height");
            }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Should not be empty.")]
        [Display(Name = "Max push-ups one set")]
        [Range(0, 60, ErrorMessage = "Should be between 0 and 60.")]
        public int MaxPushUps
        {
            get { return this.maxPushUps; }
            set 
            { 
                this.maxPushUps = value;
                this.RaisePropertyChanged("MaxPushUps");
            }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Should not be empty")]
        [Display(Name = "Max squats one set")]
        [Range(0, 100, ErrorMessage = "Should be between 0 and 100.")]
        public int MaxSquats
        {
            get { return this.maxSquats; }
            set 
            { 
                this.maxSquats = value;
                this.RaisePropertyChanged("MaxSquats");
            }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Should not be empty.")]
        [Display(Name  = "Max pull-ups one set")]
        [Range(0, 20, ErrorMessage = "Should be between 0 and 20.")]
        public int MaxPullUps
        {
            get { return this.maxPullUps; }
            set 
            { 
                this.maxPullUps = value;
                this.RaisePropertyChanged("MaxPullUps");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }
        //[Display(Name = "Goal")]
        //public string Goal
        //{
        //    get { return this.goal; }
        //    set { this.goal = value; }
        //}

        //public class SourceProviderExt : SourceProvider
        //{
        //    public override IList GetSource(string sourceName)
        //    {
        //        var list = new List<string>();
        //        if (sourceName == "Goal")
        //        {
        //            list.Add("Fit");
        //            list.Add("Strength");
        //            list.Add("Fit&Strength");
        //        }
        //        return list;
        //     }
        //}

        #endregion

        public void CalculateBmi()
        {
            int bmi;
            bmi = Convert.ToInt32(weight / Math.Pow((height / 100), 2));
        }
    }
}
