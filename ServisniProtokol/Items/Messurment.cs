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
        private bool IsValid { get; set; }

        public Measurement(string parameter, double value, string unit, bool isValid)
        {
            Parameter = parameter;
            Value = value;
            Unit = unit;
            IsValid = isValid;
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
