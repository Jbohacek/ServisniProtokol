using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServisniProtokol.Items;

namespace ServisniProtokol.Managers.SaveItemsData
{
    public class CustomerInfoData
    {
        public string Nazev { get; set; } = "";
        public string adresa { get; set; } = "";
        public string PSC { get; set; } = "";
        public string IC { get; set; } = "";

        public Customer GetCustomer()
        {
            return new Customer(Nazev, adresa, PSC, IC);
        }
    }
}
