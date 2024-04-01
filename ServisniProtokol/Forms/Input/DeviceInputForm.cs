using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServisniProtokol.Items;
using ServisniProtokol.Managers.SaveItemsData;
using ServisniProtokol.Managers.Validations;

namespace ServisniProtokol.Forms.Input
{
    public partial class DeviceInputForm : Form
    {
        private readonly DeviceInputValidation deviceInputValidation;
        public bool IsValid { get; set; } = false;
        public DeviceInfoData Data { get; set; } = new DeviceInfoData();

        public DeviceInputForm()
        {
            InitializeComponent();
            deviceInputValidation = new DeviceInputValidation(ErrorSetter);
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            if (!deviceInputValidation.Validate(tModel, tSerioveCislo, tVyrobce))
            {
                return;
            }

            Data.Model = tModel.Text;
            Data.Vyrobce = tVyrobce.Text;
            Data.SerioveCislo = tSerioveCislo.Text;

            IsValid = true;
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                PopulateData();

            }

            ErrorSetter.Clear();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public Device GetDevice()
        {
            return Data.GetDevice();
        }

        private void DeviceInputForm_Shown(object sender, EventArgs e)
        {
            PopulateData();
        }
        private void PopulateData()
        {
            tModel.Text = Data.Model;
            tVyrobce.Text = Data.Vyrobce;
            tSerioveCislo.Text = Data.SerioveCislo;
        }
    }
}
