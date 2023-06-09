using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Department
{
    class Ladder
    {
        /// <summary>
        /// Ladder Class implements real world ladder
        /// contains length and color of ladder
        /// </summary>
        
        // attributes
        private float length; 
        private string color;

        // constructor
        public Ladder(float length, string color)
        {
            this.length = length;
            this.color = color;
        }

    }
}
