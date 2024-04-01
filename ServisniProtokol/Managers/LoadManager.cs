using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ServisniProtokol.Forms.Input;
using ServisniProtokol.Items;
using ServisniProtokol.Managers.SaveItemsData;

namespace ServisniProtokol.Managers
{
    public class LoadManager
    {
        private SaveItem? LoadedItem { get; set; }



        public LoadManager()
        {

        }

        public void PopulateData(BasicInfoInputForm basicInfoInputForm, CustomerInputForm customerInputForm,
            DeviceInputForm deviceInputForm, BindingList<ListItemMeasurement> data)
        {

            if(LoadedItem == null) return;


            basicInfoInputForm.Data = LoadedItem.BasicInfo;
            customerInputForm.Data = LoadedItem.CustomerInfo;
            deviceInputForm.Data = LoadedItem.DeviceInfo;
            BindingList<ListItemMeasurement>
                inputList = new BindingList<ListItemMeasurement>(LoadedItem.Items.ToList());

            foreach (var listItemMeasurement in inputList)
            {
                data.Add(listItemMeasurement);
            }
        }

        public void Load()
        {
            if (LoadedItem == null)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SaveItem));

                var fileName = OpenDialog();
                if(string.IsNullOrEmpty(fileName) ) {return; }

                FileStream fs = new FileStream(fileName, FileMode.Open);

                LoadedItem = (SaveItem)serializer.Deserialize(fs)!;

                fs.Close();
            }
        }

        private string OpenDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    return openFileDialog.FileName;
                }
                else
                {
                    return "";
                }
            }
        }
    }
}
