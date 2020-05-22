using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.XForms.DataForm;
using Syncfusion.XForms.DataForm.Editors;
using Xamarin.Forms;
using XamarinTrainicity.Data;
using static XamarinTrainicity.Data.Info;

namespace XamarinTrainicity
{
    public class DataFormBehaviour : Behavior<ContentPage>
    {
        SfDataForm dataForm;
        Button button;
        int bmi;

        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            dataForm = bindable.FindByName<SfDataForm>("dataForm");
            dataForm.ValidationMode = ValidationMode.PropertyChanged;
            dataForm.CommitMode = CommitMode.LostFocus;
            //dataForm.SourceProvider = new SourceProviderExt();
            //dataForm.RegisterEditor("Goal", "DropDown");
            dataForm.RegisterEditor("MaxPushUps", "NumericUpDown");
            dataForm.RegisterEditor("MaxPullUps", "NumericUpDown");
            dataForm.RegisterEditor("MaxSquats", "NumericUpDown");
            dataForm.RegisterEditor("Weight", "NumericUpDown");
            dataForm.RegisterEditor("Height", "NumericUpDown");
            button = bindable.FindByName<Button>("createPlan");
            button.IsEnabled = false;
            dataForm.Validated += DataForm_Validated;
            dataForm.AutoGeneratingDataFormItem += DataForm_AutoGeneratingDataFormItem;
            dataForm.Validating += DataForm_Validating;
        }

        private void DataForm_Validated(object sender, ValidatedEventArgs e)
        {
            button.IsEnabled = (sender as SfDataForm).ItemManager.DataFormItems.TrueForAll(x => (x as DataFormItem).IsValid);
        }

        private void DataForm_Validating(object sender, ValidatingEventArgs e)
        {
            int height = (dataForm.DataObject as Info).Height;
            int weight = (dataForm.DataObject as Info).Weight;
            if (height != 0 && weight != 0 && height > 99 && weight > 99)
            {
                bmi = Convert.ToInt32(weight / Math.Pow(height / 100.0, 2));
                if (bmi > 40 ||  bmi < 15)
                {
                    Application.Current.MainPage.DisplayAlert("Sorry to say that...", "You need to visit specialist, we can't help you :(", "OK");
                    (dataForm.DataObject as Info).Height = 0;
                    (dataForm.DataObject as Info).Weight = 0;
                }
            }
        }

        private void DataForm_AutoGeneratingDataFormItem(object sender, AutoGeneratingDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null)
            {
                e.DataFormItem.TextInputLayoutSettings = new TextInputLayoutSettings()
                {
                    OutlineCornerRadius = 25
                };
            }
            if (e.DataFormItem != null && e.DataFormItem.Name == "MaxPushUps")
            {
                (e.DataFormItem as DataFormNumericUpDownItem).Maximum = 60;
                (e.DataFormItem as DataFormNumericUpDownItem).Minimum = 0;
                (e.DataFormItem as DataFormNumericUpDownItem).AutoReverse = true;
            }
            if (e.DataFormItem != null && e.DataFormItem.Name == "MaxSquats")
            {
                (e.DataFormItem as DataFormNumericUpDownItem).Maximum = 100;
                (e.DataFormItem as DataFormNumericUpDownItem).Minimum = 0;
                (e.DataFormItem as DataFormNumericUpDownItem).AutoReverse = true;
            }
            if (e.DataFormItem != null && e.DataFormItem.Name == "MaxPullUps")
            {
                (e.DataFormItem as DataFormNumericUpDownItem).Maximum = 20;
                (e.DataFormItem as DataFormNumericUpDownItem).Minimum = 0;
                (e.DataFormItem as DataFormNumericUpDownItem).AutoReverse = true;
            }
            if (e.DataFormItem != null && e.DataFormItem.Name == "Weight")
            {
                (e.DataFormItem as DataFormNumericUpDownItem).Maximum = 150;
                (e.DataFormItem as DataFormNumericUpDownItem).Minimum = 0;
            }
            if (e.DataFormItem != null && e.DataFormItem.Name == "Height")
            {
                (e.DataFormItem as DataFormNumericUpDownItem).Maximum = 220;
                (e.DataFormItem as DataFormNumericUpDownItem).Minimum = 0;
            }
        }
    }
}
