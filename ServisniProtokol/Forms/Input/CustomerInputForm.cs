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
    public partial class CustomerInputForm : Form
    {
        private readonly CustomerValidation customerValidation;

        public CustomerInfoData Data { get; set; }
        public bool IsValid = true;


        public CustomerInputForm()
        {
            InitializeComponent();
            Data = new CustomerInfoData();
            customerValidation = new CustomerValidation(SetError);

        }


        public Customer GetCustomer()
        {
            if (!IsValid)
            {
                throw new Exception("Customer neni valid");
            }

            return Data.GetCustomer();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                PopulateData();
            }

            SetError.Clear();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            if (!customerValidation.Validate(tNazev, tAdresa, tPSC, tIco))
            {
                return;
            }

            Data.Nazev = tNazev.Text;
            Data.adresa = tAdresa.Text;
            Data.PSC = tPSC.Text;
            Data.IC = tIco.Text;

            IsValid = true;
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void CustomerInputForm_Shown(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void PopulateData()
        {
            tNazev.Text = Data.Nazev;
            tAdresa.Text = Data.adresa;
            tPSC.Text = Data.PSC;
            tIco.Text = Data.IC;
        }
    }
}
