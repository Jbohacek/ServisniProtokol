using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ServisniProtokol.Forms.Input;
using ServisniProtokol.Managers.SaveItemsData;

namespace ServisniProtokol.Managers
{
    public class SaveManager
    {
        private SaveItem Item { get; set; }

        public SaveManager(SaveItem item)
        {
            this.Item = item;
        }

        public bool Save()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return false;
            }

            Stream myStream;
            if ((myStream = saveFileDialog.OpenFile()) != null)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SaveItem));

                serializer.Serialize(myStream, Item);
                myStream.Close();
                return true;
            }

            return false;


        }

    }
}
