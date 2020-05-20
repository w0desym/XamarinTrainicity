using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.XForms.DataForm;
using Syncfusion.XForms.DataForm.Editors;
using Xamarin.Forms;
using static XamarinTrainicity.Data.Info;

namespace XamarinTrainicity
{
    public class DataFormBehaviour : Behavior<ContentPage>
    {
        SfDataForm dataForm;
        Button button;

        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            dataForm = bindable.FindByName<SfDataForm>("dataForm");
            dataForm.ValidationMode = ValidationMode.LostFocus;
            dataForm.CommitMode = CommitMode.LostFocus;
            //dataForm.SourceProvider = new SourceProviderExt();
            //dataForm.RegisterEditor("Goal", "DropDown");
            dataForm.RegisterEditor("MaxPushUps", "NumericUpDown");
            dataForm.RegisterEditor("MaxPullUps", "NumericUpDown");
            dataForm.RegisterEditor("MaxSquats", "NumericUpDown");
            button = bindable.FindByName<Button>("createPlan");
            button.IsEnabled = false;
            dataForm.Validated += DataForm_Validated;
            dataForm.AutoGeneratingDataFormItem += DataForm_AutoGeneratingDataFormItem;
        }

        private void DataForm_Validated(object sender, ValidatedEventArgs e)
        {
            button.IsEnabled = (sender as SfDataForm).ItemManager.DataFormItems.TrueForAll(x => (x as DataFormItem).IsValid);
        }

        private void DataForm_AutoGeneratingDataFormItem(object sender, AutoGeneratingDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null && e.DataFormItem.Name == "MaxPushUps")
            {
                (e.DataFormItem as DataFormNumericUpDownItem).Maximum = 60;
                (e.DataFormItem as DataFormNumericUpDownItem).Minimum = 0;
                (e.DataFormItem as DataFormNumericUpDownItem).AutoReverse = true;
            }
            if (e.DataFormItem != null && e.DataFormItem.Name == "MaxSquats")
            {
                (e.DataFormItem as DataFormNumericUpDownItem).Maximum = 150;
                (e.DataFormItem as DataFormNumericUpDownItem).Minimum = 0;
                (e.DataFormItem as DataFormNumericUpDownItem).AutoReverse = true;
            }
            if (e.DataFormItem != null && e.DataFormItem.Name == "MaxPullUps")
            {
                (e.DataFormItem as DataFormNumericUpDownItem).Maximum = 30;
                (e.DataFormItem as DataFormNumericUpDownItem).Minimum = 0;
                (e.DataFormItem as DataFormNumericUpDownItem).AutoReverse = true;
            }
        }
    }
}
