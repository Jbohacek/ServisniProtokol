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
using ServisniProtokol.Managers.Validations;

namespace ServisniProtokol.Forms.Input
{
    public partial class DeviceInputForm : Form
    {
        private readonly DeviceInputValidation deviceInputValidation;
        public bool IsValid { get; set; } = false;

        public string Vyrobce { get; set; } = "";
        public string Model { get; set; } = "";
        public string SerioveCislo { get; set; } = "";

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

            Model = tModel.Text;
            Vyrobce = tVyrobce.Text;
            SerioveCislo = tSerioveCislo.Text;

            IsValid = true;
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                tModel.Text = Model;
                tVyrobce.Text = Vyrobce;
                tSerioveCislo.Text = SerioveCislo;

            }

            ErrorSetter.Clear();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public Device GetDevice()
        {
            if (!IsValid) throw new Exception("Device Neni valid");

            return new Device(Vyrobce, Model, SerioveCislo);
        }
    }
}
