using System;
using Syncfusion.XForms.DataForm;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

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
        private string goal;

        #endregion

        #region Constructors

        public Info()
        {

        }

        #endregion

        #region Properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public DateTime? BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int MaxPushUps
        {
            get { return this.maxPushUps; }
            set { this.maxPushUps = value; }
        }

        public int MaxSquats
        {
            get { return this.maxSquats; }
            set { this.maxSquats = value; }
        }

        public int MaxPullUps
        {
            get { return this.maxPullUps; }
            set { this.maxPullUps = value; }
        }

        public string Goal
        {
            get { return this.goal; }
            set { this.goal = value; }
        }

        #endregion

    }
}
