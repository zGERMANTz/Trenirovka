using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trenirovka
{
    internal class Smesharik
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public string characteristic { get; private set; }

        public Smesharik(int _id, string _name, string _characteristic)
        {
            id = _id;
            name = _name;
            characteristic = _characteristic;
        }
    }

}
