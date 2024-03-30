using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServisniProtokol.Items;
using ServisniProtokol.Managers.Validations;

namespace ServisniProtokol.Forms.Input
{
    public partial class MessureInputForm : Form
    {
        private readonly MeasurementValidation measurementValidation;
        public bool IsValid { get; set; } = false;

        public string Parameter { get; set; } = "";
        public string Value { get; set; } = "";
        public string Unit { get; set; } = "";
        public bool IsValidTest { get; set; } = false;

        public MessureInputForm()
        {
            InitializeComponent();
            measurementValidation = new MeasurementValidation(ErrorSetter);
        }

        public void ReWrite()
        {
            tParametr.Text = Parameter;
            tJednotka.Text = Unit;
            tNamerenaJednotka.Text = Value;
            cVyhovuje.Checked = IsValidTest;
        }

        public ListItemMeasurement GetListItemMeasurement()
        {
            if (IsValid == false) throw new Exception("Meassurment is not valid");
            return new ListItemMeasurement(Parameter, Convert.ToDouble(Value), Unit, IsValidTest);
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            if (!measurementValidation.Validate(tParametr, tNamerenaJednotka, tJednotka))
            {
                return;
            }


            Parameter = tParametr.Text;
            Value = tNamerenaJednotka.Text;
            Unit = tJednotka.Text;
            IsValidTest = cVyhovuje.Checked;
            Value = Value.Replace(".", ",");


            IsValid = true;
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
