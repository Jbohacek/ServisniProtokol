using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServisniProtokol.Interfaces;

namespace ServisniProtokol.Items
{
    public class ServisProtokol : IHtmlDisplayAble
    {
        private string NumProtokol { get; set; }
        private DateTime DateOfMeasurement { get; set; }
        private Customer Customer { get; set; }
        private Device Device { get; set; }
        private Measurement[] Measurement { get; set; }

        public ServisProtokol(string numProtokol, DateTime dateOfMeasurement, Customer customer, Device device, Measurement[] measurement)
        {
            NumProtokol = numProtokol;
            DateOfMeasurement = dateOfMeasurement;
            Customer = customer;
            Device = device;
            Measurement = measurement;
            
        }

        public bool IsOk()
        {
            bool ret = Measurement.All(x => x.IsValid != false);
            return ret;
        }


        public string ConvertToHtml()
        {
            var result = "";

            string start = File.ReadAllText("Resources/Start.txt");
            result += start;

            result += this.DefineCssStyles();
            result += Customer.DefineCssStyles();
            result += Device.DefineCssStyles();

            if (Measurement.Length > 0)
            {
                result += Measurement[0].DefineCssStyles();
            }
            else
            {
                result += "div#mereni { clear:both; padding:1em; }\r\ndiv#mereni table { width:100%; }\r\ndiv#mereni table th { text-align:left; }\r\n";
            }

            string middle = File.ReadAllText("Resources/Middle.txt");
            result += middle;

            result +=
                "<div id='protokol'>\r\n" +
                "<h1>Potvrzení o provedení měření</h1>\r\n" +
                $"<div id='datum'>Datum měření: {DateOfMeasurement.ToShortDateString()}</div>\r\n" +
                $"<div id='cisloProtokolu'>Číslo protokolu: {NumProtokol}</div>";

            result += Customer.ConvertToHtml();
            result += Device.ConvertToHtml();

            result += "<div id='mereni'>\r\n<h2>Měření</h2>\r\n<table>";
            result += "<tr> <th>Parametr</th> <th>Naměřená hodnota</th> <th>Vyhovuje</th> </tr>";
            if (Measurement.Length > 0)
            {
                foreach (var measurement in Measurement)
                {
                    result += measurement.ConvertToHtml();
                }
                
            }
            result += "</table>";
            if (IsOk())
            {
                result += "</div>\r\n<div id='zaver'>Zařízení je schopné dalšího provozu</div>\r\n</div>";

            }
            else
            {
                result += "</div>\r\n<div id='zaver'>Zařízení není schopné dalšího provozu</div>\r\n</div>";
            }


            result += File.ReadAllText("Resources/End.txt");

            return result;
        }

        public string DefineCssStyles()
        {
            return
                "h1 { text-align:center; }\r\n" +
                "div#protokol { margin:2em; border:1px solid black; }\r\n" +
                "div#datum { float:left; margin:1em; width:40%;  }\r\n" +
                "div#cisloProtokolu { text-align:right; float:right; margin:1em; width:40%; }\r\n" +
                "div#zaver { text-align:center; font-weight:bold; font-size:1.2em; }";
        }
    }
}
