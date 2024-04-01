using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServisniProtokol.Interfaces;

namespace ServisniProtokol.Items
{
    public class Measurement : IHtmlDisplayAble
    {
        private string Parameter { get; set; }
        private double Value { get; set; }
        private string Unit { get; set; }
        public bool IsValid { get; set; }

        public Measurement(string parameter, double value, string unit, bool isValid)
        {
            Parameter = parameter;
            Value = value;
            Unit = unit;
            IsValid = isValid;
        }

        public string ConvertToHtml()
        {
            var res = IsValid == true ? "Ano" : "Ne";

            return $"<tr><td>{Parameter}</td><td>{Value} {Unit}</td><td>{res}</td></tr>";
        }

        public string DefineCssStyles()
        {
            return
                "div#mereni { clear:both; padding:1em; }\r\ndiv#mereni table { width:100%; }\r\ndiv#mereni table th { text-align:left; }\r\n";
        }
    }


}
