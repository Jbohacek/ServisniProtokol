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
            return "<div id='zarizeni'>\r\n" +
                   "<h2>Zařízení</h2>\r\n" +
                   $"<div>Výrobce: {Creator}</div>\r\n" +
                   $"<div>Model: {DeviceModel}</div>\r\n" +
                   $"<div>Sériové číslo: {SerialNumber}</div>\r\n" +
                   "</div>";
        }

        public string DefineCssStyles()
        {
            return "div#zarizeni { border:1px solid black; margin:1em; padding:1em; width:40%; float:right; }";
        }
    }
}
