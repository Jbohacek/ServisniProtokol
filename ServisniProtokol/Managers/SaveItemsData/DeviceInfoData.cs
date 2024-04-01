using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServisniProtokol.Items;

namespace ServisniProtokol.Managers.SaveItemsData
{
    public class DeviceInfoData
    {
        public string Vyrobce { get; set; } = "";
        public string Model { get; set; } = "";
        public string SerioveCislo { get; set; } = "";

        public Device GetDevice()
        {
            return new Device(Vyrobce, Model, SerioveCislo);
        }
    }
}
