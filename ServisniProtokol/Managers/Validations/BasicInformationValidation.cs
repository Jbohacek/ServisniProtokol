using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokol.Managers.Validations
{
    public class BasicInformationValidation : Validation
    {
        public BasicInformationValidation(ErrorProvider errorProvider) : base(errorProvider)
        {
        }

        public bool Validate(params TextBox[] inputs)
        {
            return !CheckIfEmptyText(inputs);
        }

            
    }
}
