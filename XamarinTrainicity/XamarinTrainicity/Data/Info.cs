using System;
using Syncfusion.XForms.DataForm;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Essentials;
using System.Collections;

namespace XamarinTrainicity.Data
{
    public class Info
    {
        #region Fields

        private string name;
        private DateTime? birthDate;
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
        [DisplayOptions(ValidMessage = "All good.")]
        [StringLength(15, ErrorMessage = "Name should not exceed 15 characters")]
        [Display(Name = "Name")]
        [MinLength(4, ErrorMessage = "Name should be longer")]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Should not be empty.")]
        [DisplayOptions(ValidMessage = "All good.")]
        [Display(Name = "Date of Birth")]
        [DateRange(MinYear = 1980, MaxYear = 2005, ErrorMessage = "This app is for people from 15 to 40 years old.")]
        public DateTime? BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Should not be empty.")]
        [Display(Name = "Weight, kg")]
        [Range(40, 150, ErrorMessage = "Should be between 40 and 150.")]
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Should not be empty.")]
        [Display(Name = "Height, cm")]
        [Range(140, 220, ErrorMessage = "Should be between 140 and 220.")]
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Should not be empty.")]
        [Display(Name = "Max push-ups one set")]
        [Range(0, 60, ErrorMessage = "Should be between 0 and 60.")]
        public int MaxPushUps
        {
            get { return this.maxPushUps; }
            set { this.maxPushUps = value; }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Should not be empty")]
        [Display(Name = "Max squats one set")]
        [Range(0, 150, ErrorMessage = "Should be between 0 and 150.")]
        public int MaxSquats
        {
            get { return this.maxSquats; }
            set { this.maxSquats = value; }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Should not be empty.")]
        [Display(Name = "Max pull-ups one set")]
        [Range(0, 30, ErrorMessage = "Should be between 0 and 30.")]
        public int MaxPullUps
        {
            get { return this.maxPullUps; }
            set { this.maxPullUps = value; }
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

    }
}
