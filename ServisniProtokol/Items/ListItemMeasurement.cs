using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServisniProtokol.Forms.Input;

namespace ServisniProtokol.Items
{
    public class ListItemMeasurement
    {
        public string Parameter { get; set; }
        public double Value { get; set; }
        public string Unit { get; set; }
        public bool IsValid { get; set; }

        public ListItemMeasurement(string parameter, double value, string unit, bool isValid)
        {
            Parameter = parameter;
            Value = value;
            Unit = unit;
            IsValid = isValid;
        }

        public MessureInputForm GetForm()
        {
            MessureInputForm form = new MessureInputForm();
            form.Parameter = Parameter;
            form.Value = Value.ToString();
            form.Unit = Unit;
            form.IsValidTest = IsValid;
            form.ReWrite();

            return form;
        }


        public Measurement GetMeasurement()
        {
            return new(Parameter, Value, Unit, IsValid);
        }

        private ListItemMeasurement()
        {
            
        }
    }
}
