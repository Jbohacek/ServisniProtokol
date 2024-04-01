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
            return
                "<div id='zakaznik'>\r\n" +
                "<h2>Zákazník</h2>\r\n" +
                $"<div>Název: {Name}</div>\r\n" +
                $"<div>Adresa: {Address}</div>\r\n" +
                $"<div>PSČ: {Psc}</div>\r\n" +
                $"<div>IČ: {Ic}</div>\r\n</div>";
        }

        public string DefineCssStyles()
        {
            return "div#zakaznik { border:1px solid black; margin:1em; padding:1em; width:40%; float:left; }";
        }
    }
}
