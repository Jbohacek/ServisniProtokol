using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokol.Managers.Validations
{
    internal class DeviceInputValidation : Validation
    {
        public DeviceInputValidation(ErrorProvider errorProvider) : base(errorProvider)
        {
        }
        public bool Validate(params TextBox[] inputs)
        {
            return !CheckIfEmptyText(inputs);
        }
    }
}
