using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle
{
    
    class MountainBike : Bicycle
    /// <summary>
    /// inherited class of bicycle with seatheight as attribute
    /// </summary>
    {
        // attributes
        public int seat_height;

        // constructor

        public MountainBike(int seatheight,int cadence, int speed, int gear) : base(cadence, gear, speed)
        {
            this.seat_height = seatheight;
        }

        // methods
        public void Set_Seat_Height(int seatheight)
        {
            if (seatheight >= 0 )
            {
                this.seat_height = seatheight;
            }
        }
    }
}
