using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ServisniProtokol.Managers.Validations
{
    public class CustomerValidation : Validation
    {
        public CustomerValidation(ErrorProvider errorProvider) : base(errorProvider)
        {

        }

        private static readonly Regex _psc = new Regex(@"^\d{3} \d{2}$");
        private static readonly Regex _ic = new Regex(@"^\d{6}$");

        public bool Validate(TextBox name, TextBox address, TextBox psc, TextBox ic)
        {
            bool isValid = true;

            if (CheckIfEmptyText(name, address, psc, ic))
            {
                isValid = false;
            }

            if (!_psc.IsMatch(psc.Text))
            {
                SetError(psc, "Nema formát PSC \"131 00\"");
                isValid = false;
            }

            if (!_ic.IsMatch(ic.Text))
            {
                SetError(ic,"Nema format IC = 6 cislic");
                isValid = false;
            }

            return isValid;
        }
    }
}
