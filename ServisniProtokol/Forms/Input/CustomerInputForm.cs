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
    public partial class CustomerInputForm : Form
    {
        private readonly CustomerValidation customerValidation;

        public bool IsValid = true;


        public CustomerInputForm()
        {
            InitializeComponent();
            customerValidation = new CustomerValidation(SetError);

        }

        public string Nazev = "";
        public string adresa = "";
        public string PSC = "";
        public string IC = "";



        public Customer GetCustomer()
        {
            if (!IsValid)
            {
                throw new Exception("Customer neni valid");
            }

            return new Customer(Nazev, adresa, PSC, IC);
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                tNazev.Text = Nazev;
                tAdresa.Text = adresa;
                tPSC.Text = PSC;
                tIco.Text = IC;
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

            Nazev = tNazev.Text;
            adresa = tAdresa.Text;
            PSC = tPSC.Text;
            IC = tIco.Text;

            IsValid = true;
            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
