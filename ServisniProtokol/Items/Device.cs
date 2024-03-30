using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServisniProtokol.Interfaces;

namespace ServisniProtokol.Items
{
    public class Device : IHtmlDisplayAble
    {
        private string Creator { get; set; }
        private string DeviceModel { get; set; }
        private string SerialNumber { get; set; }

        public Device(string creator, string deviceModel, string serialNumber)
        {
            Creator = creator;
            DeviceModel = deviceModel;
            SerialNumber = serialNumber;
        }

        public string ConvertToHtml()
        {
            throw new NotImplementedException();
        }

        public string DefineCssStyles()
        {
            throw new NotImplementedException();
        }
    }
}
