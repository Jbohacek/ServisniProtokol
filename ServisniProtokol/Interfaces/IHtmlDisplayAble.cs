using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokol.Interfaces
{
    public interface IHtmlDisplayAble
    {
        public string ConvertToHtml();

        public string DefineCssStyles();
    }
}
