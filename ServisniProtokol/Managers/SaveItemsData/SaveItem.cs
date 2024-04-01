using ServisniProtokol.Forms.Input;
using ServisniProtokol.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokol.Managers.SaveItemsData
{
    public class SaveItem
    {
        public BasicInfoData BasicInfo { get; set; }
        public DeviceInfoData DeviceInfo { get; set; }
        public CustomerInfoData CustomerInfo { get; set; }

        public ListItemMeasurement[] Items { get; set; }


        public SaveItem(BasicInfoData basicInfo, DeviceInfoData deviceInfo, CustomerInfoData customerInfo, ListItemMeasurement[] items)
        {
            this.BasicInfo = basicInfo;
            this.DeviceInfo = deviceInfo;
            this.CustomerInfo = customerInfo;
            Items = items;
        }

        private SaveItem()
        {

        }
    }
}
