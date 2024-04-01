using System.ComponentModel;
using System.Resources;
using ServisniProtokol.Forms;
using ServisniProtokol.Forms.Input;
using ServisniProtokol.Items;
using ServisniProtokol.Managers;
using ServisniProtokol.Managers.SaveItemsData;

namespace ServisniProtokol
{
    public partial class MainForm : Form
    {
        private BasicInfoInputForm _basicInfoInputForm = new BasicInfoInputForm();
        private CustomerInputForm _customerInputForm = new CustomerInputForm();
        private DeviceInputForm _deviceInputForm = new DeviceInputForm();

        private Customer? _customer = null;
        private Device? _device = null;

        private BindingList<ListItemMeasurement> _measurements = new BindingList<ListItemMeasurement>();

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
                PopulateBasicInfoData();
            }
        }

        private void lEditCustomer_Click(object sender, EventArgs e)
        {
            _customerInputForm.ShowDialog();
            if (_customerInputForm.DialogResult == DialogResult.OK)
            {
                _customer = _customerInputForm.GetCustomer();

                PopulateCustomerInfoData();
            }
        }

        private void bEditDevice_Click(object sender, EventArgs e)
        {
            _deviceInputForm.ShowDialog();
            if (_deviceInputForm.DialogResult == DialogResult.OK)
            {
                _device = _deviceInputForm.GetDevice();

                PopulateDeviceInfoData();
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

        private void bSave_Click(object sender, EventArgs e)
        {
            SaveItem itemToSave =
                new SaveItem(_basicInfoInputForm.Data, _deviceInputForm.Data, _customerInputForm.Data, _measurements.ToArray());

            SaveManager saver = new SaveManager(itemToSave);
            saver.Save();
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            LoadManager loader = new LoadManager();
            loader.Load();
            loader.PopulateData(_basicInfoInputForm,
                _customerInputForm,
                _deviceInputForm,
                _measurements);

            _measurements.ResetBindings();

            PopulateBasicInfoData();
            PopulateCustomerInfoData();
            PopulateDeviceInfoData();
        }

        private void PopulateBasicInfoData()
        {
            var data = _basicInfoInputForm.Data;
            lCisloProtokoluTEXT.Text = data.NumProtokol;
            lDatumMereniTEXT.Text = data.DateOfMeasurement.ToShortDateString();
        }

        private void PopulateCustomerInfoData()
        {
            var data = _customerInputForm.Data;
            lNazevTEXT.Text = data.Nazev;
            lAdesaTEXT.Text = data.adresa;
            lPSCTEXT.Text = data.PSC;
            lICText.Text = data.IC;
        }

        private void PopulateDeviceInfoData()
        {
            var data = _deviceInputForm.Data;

            lVyrobceTEXT.Text = data.Vyrobce;
            lModelTEXT.Text = data.Model;
            lSerioveTEXT.Text = data.SerioveCislo;
        }

        private void bPreview_Click(object sender, EventArgs e)
        {
            PreviewItem previewItem = new PreviewItem(_basicInfoInputForm.Data, _deviceInputForm.Data,
                _customerInputForm.Data, _measurements.ToArray());
            PreviewForm previewForm = new PreviewForm(previewItem);
            previewForm.ShowDialog();
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            _customer = _customerInputForm.GetCustomer();
            _device = _deviceInputForm.GetDevice();

            ServisProtokol protokol = new ServisProtokol(
                _basicInfoInputForm.Data.NumProtokol,
                _basicInfoInputForm.Data.DateOfMeasurement,
                _customer, 
                _device,
                _measurements.Select(x => x.GetMeasurement()).ToArray());

            var result = protokol.ConvertToHtml();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = @"html files (*.html)|*.html|All files (*.*)|*.*";
            
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = ".html";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName,result);
                MessageBox.Show("Úspìšnì exportováno");
            }


        }
    }
}
