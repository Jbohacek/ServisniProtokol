using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokol.Managers.SaveItemsData
{
    public class BasicInfoData
    {
        public string NumProtokol { get; set; } = "";
        public DateTime DateOfMeasurement { get; set; } = DateTime.Now;
    }
}
