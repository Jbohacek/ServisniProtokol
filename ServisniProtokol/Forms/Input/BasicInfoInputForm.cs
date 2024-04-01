using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServisniProtokol.Managers.SaveItemsData;
using ServisniProtokol.Managers.Validations;

namespace ServisniProtokol.Forms.Input
{
    public partial class BasicInfoInputForm : Form
    {
        private readonly BasicInformationValidation _validation;
        public BasicInfoData Data { get; set; }

        public BasicInfoInputForm()
        {
            InitializeComponent();
            Data = new BasicInfoData();
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

            Data.NumProtokol = tCisloProduktu.Text;
            Data.DateOfMeasurement = dDatum.Value;
            IsValid = true;

            this.DialogResult = DialogResult.OK;
            ErrorSetter.Clear();
            this.Close();
        }

        public bool IsValid = false;

        private void bCancel_Click(object sender, EventArgs e)
        {
            PopulateData();

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BasicInfoInputForm_Shown(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void PopulateData()
        {
            tCisloProduktu.Text = Data.NumProtokol;
            dDatum.Value = Data.DateOfMeasurement;
        }
    }
}
