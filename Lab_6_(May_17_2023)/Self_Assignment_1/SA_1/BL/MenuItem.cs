using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_1
{
    class MenuItem
    {
        // attributes
        public string name;
        public string type;
        public int price;

        // methods
        public MenuItem(string name, string type, int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }


    }
}
