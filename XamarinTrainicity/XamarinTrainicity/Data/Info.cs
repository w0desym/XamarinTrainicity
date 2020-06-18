using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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

        #endregion

        #region Constructors

        public Info()
        {

        }

        #endregion

        #region Properties

        [Required(AllowEmptyStrings = false, ErrorMessage = "Should not be empty.")]
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
        [Display(Name = "Age")]
        [Range(16, 40, ErrorMessage = "This app is for people from 16 to 40 years old.")]
        public int Age
        {
            get { return this.age; }
            set 
            { 
                this.age = value;
                this.RaisePropertyChanged("Age");
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
        [Range(0, 200, ErrorMessage = "Should be between 0 and 200.")]
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

        #endregion
    }
}
