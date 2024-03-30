using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ServisniProtokol.Managers.Validations
{
    public class MeasurementValidation : Validation
    {
        public MeasurementValidation(ErrorProvider err) : base(err)
        {

        }
        private static readonly Regex _value = new Regex(@"^\d+[.,]?\d*$");


        public bool Validate(TextBox parameter, TextBox value, TextBox unit)
        {
            if (CheckIfEmptyText(parameter, value, unit))
            {
                return false;
            }

            if (!_value.IsMatch(value.Text))
            {
                SetError(value, "Musí být číslo");
                return false;
            }
            return true;
        }
    }
}
