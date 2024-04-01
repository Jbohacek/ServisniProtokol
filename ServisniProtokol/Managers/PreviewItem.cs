using ServisniProtokol.Items;
using ServisniProtokol.Managers.SaveItemsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokol.Managers
{
    public class PreviewItem
    {
        public BasicInfoData BasicInfo { get; set; }
        public DeviceInfoData DeviceInfo { get; set; }
        public CustomerInfoData CustomerInfo { get; set; }

        public ListItemMeasurement[] Items { get; set; }

        public bool DeviceIsCapable = true;


        public PreviewItem(BasicInfoData basicInfo, DeviceInfoData deviceInfo, CustomerInfoData customerInfo, ListItemMeasurement[] items)
        {
            this.BasicInfo = basicInfo;
            this.DeviceInfo = deviceInfo;
            this.CustomerInfo = customerInfo;
            Items = items;

            if (Items.Any(x => x.IsValid == false))
            {
                DeviceIsCapable = false;
            }

            if (Items.Length == 0)
            {
                DeviceIsCapable = false;
            }

        }
    }
}
