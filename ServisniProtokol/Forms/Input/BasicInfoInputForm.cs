using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServisniProtokol.Managers.Validations;

namespace ServisniProtokol.Forms.Input
{
    public partial class BasicInfoInputForm : Form
    {
        private readonly BasicInformationValidation _validation;


        public BasicInfoInputForm()
        {
            InitializeComponent();
            NumProtokol = "";
            _validation = new BasicInformationValidation(ErrorSetter);
        }

        private bool Check()
        {
            if (!_validation.Validate(tCisloProduktu))
            {
                return false;
            }

            return true;
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                return;
            }

            NumProtokol = tCisloProduktu.Text;
            DateOfMeasurement = dDatum.Value;
            IsValid = true;

            this.DialogResult = DialogResult.OK;
            ErrorSetter.Clear();
            this.Close();
        }

        public string NumProtokol { get; set; }
        public DateTime DateOfMeasurement { get; set; }

        public bool IsValid = false;

        private void bCancel_Click(object sender, EventArgs e)
        {
            tCisloProduktu.Text = NumProtokol;
            dDatum.Value = DateOfMeasurement;

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
