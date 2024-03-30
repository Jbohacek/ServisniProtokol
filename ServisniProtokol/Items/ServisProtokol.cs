using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokol.Items
{
    public class ServisProtokol
    {
        private string NumProtokol { get; set; }
        private DateTime DateOfMeasurement { get; set; }
        private Customer Customer { get; set; }
        private Device Device { get; set; }
        private Measurement[] Measurement { get; set; }

        public ServisProtokol(string numProtokol, DateTime dateOfMeasurement, Customer customer, Device device, Measurement[] measurement)
        {
            NumProtokol = numProtokol;
            DateOfMeasurement = dateOfMeasurement;
            Customer = customer;
            Device = device;
            Measurement = measurement;
        }
    }
}
