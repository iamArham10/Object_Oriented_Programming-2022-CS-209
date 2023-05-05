using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Angle
{
    class Ship
    {
        // attributes
        public string ship_number;
        public Angle Longitude;
        public Angle Latitude;
        
        // constructors
        public Ship(string ship_number, Angle longitude, Angle latitude)
        {
            this.ship_number = ship_number;
            Longitude = longitude;
            Latitude = latitude;
        }

        public string Return_Serial_Number()
        {
            return ship_number;
        }

    }
}
