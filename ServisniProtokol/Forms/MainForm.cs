using System.ComponentModel;
using ServisniProtokol.Forms.Input;
using ServisniProtokol.Items;

namespace ServisniProtokol
{
    public partial class MainForm : Form
    {
        private BasicInfoInputForm _basicInfoInputForm = new BasicInfoInputForm();
        private CustomerInputForm _customerInputForm = new CustomerInputForm();
        private DeviceInputForm _deviceInputForm = new DeviceInputForm();

        private Customer? _customer = null;
        private Device? _device = null;

        private readonly BindingList<ListItemMeasurement> _measurements = new BindingList<ListItemMeasurement>();

        public MainForm()
        {
            InitializeComponent();
            DataGridMeassurementList.DataSource = _measurements;
        }

        private void bEditBasicInfo_Click(object sender, EventArgs e)
        {
            _basicInfoInputForm.ShowDialog();
            if (_basicInfoInputForm.DialogResult == DialogResult.OK)
            {
                lCisloProtokoluTEXT.Text = _basicInfoInputForm.NumProtokol;
                lDatumMereniTEXT.Text = _basicInfoInputForm.DateOfMeasurement.ToShortDateString();
            }
        }

        private void lEditCustomer_Click(object sender, EventArgs e)
        {
            _customerInputForm.ShowDialog();
            if (_customerInputForm.DialogResult == DialogResult.OK)
            {
                _customer = _customerInputForm.GetCustomer();

                lNazevTEXT.Text = _customerInputForm.Nazev;
                lAdesaTEXT.Text = _customerInputForm.adresa;
                lPSCTEXT.Text = _customerInputForm.PSC;
                lICText.Text = _customerInputForm.IC;
            }
        }

        private void bEditDevice_Click(object sender, EventArgs e)
        {
            _deviceInputForm.ShowDialog();
            if (_deviceInputForm.DialogResult == DialogResult.OK)
            {
                _device = _deviceInputForm.GetDevice();

                lVyrobceTEXT.Text = _deviceInputForm.Vyrobce;
                lModelTEXT.Text = _deviceInputForm.Model;
                lSerioveTEXT.Text = _deviceInputForm.SerioveCislo;
            }
        }

        private ListItemMeasurement? GetSelectedMeasurement()
        {
            if (DataGridMeassurementList.SelectedCells.Count == 0)
            {
                MessageBox.Show("neni vybraná hodnota");
                return null;
            }

            return (ListItemMeasurement)DataGridMeassurementList.Rows[DataGridMeassurementList.SelectedCells[0].RowIndex].DataBoundItem;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            MessureInputForm inputForm = new MessureInputForm();

            inputForm.ShowDialog();

            if (inputForm.DialogResult != DialogResult.OK) return;

            _measurements.Add(inputForm.GetListItemMeasurement());
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            var editValue = GetSelectedMeasurement();

            if (editValue != null)
            {
                var EditForm = editValue.GetForm();
                EditForm.ShowDialog();
                editValue.Value = Convert.ToDouble(EditForm.Value);
                editValue.Unit = EditForm.Unit;
                editValue.IsValid = EditForm.IsValidTest;
                editValue.Parameter = EditForm.Parameter;

                _measurements.ResetItem(_measurements.IndexOf(editValue));
            }
        }

        private void bRemoveItem_Click(object sender, EventArgs e)
        {
            var removeValue = GetSelectedMeasurement();

            if (removeValue != null)
            {
                _measurements.Remove(removeValue);
            }
        }
    }
}
