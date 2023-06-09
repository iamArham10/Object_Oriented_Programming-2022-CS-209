using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    public class Shape
    {
        public Shape() { }
        public virtual double Get_Area()
        {
            return 0;
        }
        public virtual string Get_Name()
        {
            return "undefined";
        }
    }
}
