using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace jsoner
{
    public class human
    {
        public string name;
        public string favanim;

        public human(string Name, string favnanim)
        {
            name = Name;
            favanim = favnanim;
        }
    }
}
