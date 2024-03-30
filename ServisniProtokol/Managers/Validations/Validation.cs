using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokol.Managers.Validations
{
    public abstract class Validation
    {
        protected Validation(ErrorProvider errorProvider)
        {
            ErrorProvider = errorProvider;
        }

        private ErrorProvider ErrorProvider { get; set; }

        public void SetError(Control errorSet, string message = "Nutné vyplnit")
        {
            ErrorProvider.SetError(errorSet,message);
        }

        public void Clear()
        {
            ErrorProvider.Clear();
        }

        public bool CheckIfEmptyText(params TextBox[] textBoxes)
        {
            Clear();
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    SetError(textBox);
                    return true;
                }
            }

            return false;
        }
    }
}
