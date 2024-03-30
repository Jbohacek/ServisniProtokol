using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServisniProtokol.Interfaces;

namespace ServisniProtokol.Items
{
    public class Customer : IHtmlDisplayAble
    {
        private string Name { get; set; }

        private string Address { get; set; }

        private string Psc { get; set; }

        private string Ic { get; set; }


        public Customer(string name, string address, string psc, string ic)
        {
            Name = name;
            Address = address;
            Psc = psc;
            Ic = ic;
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
