using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle
{
    class Bicycle
    /// <summary>
    /// Bicycle Class implements Bicycle object
    /// having gear, speed and cadence(rate of revolutions per minute
    /// </summary>
    {
        // attributes
        public int cadence;
        public int gear;
        public int speed;
        
        // constructor
        public Bicycle(int cadence, int gear, int speed)
        {

            Set_Cadence(cadence);
            Set_Gear(gear);
            if (speed >= 0)
            {
                this.speed = speed;
            }
        }
        // methods
        public void Set_Cadence(int cadence) // set cadence
        {
            if (cadence >= 0)
            {
                this.cadence = cadence;
            }
        }

        public void Set_Gear(int gear) // sets the gear
        {
            if (gear >= 0)
            {
                this.gear = gear;
            }
        }

        public void Apply_Break(int decrement) // decreasese the speed
        {
            if (decrement >= this.speed && (this.speed - decrement >= 0))
            {
                this.speed -= decrement;
            }
        }

        public void Speed_Up(int increment)
        {
            if (increment > 0)
            {
                this.speed += increment;
            }
        }




    }
}
