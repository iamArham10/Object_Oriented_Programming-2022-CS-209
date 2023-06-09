using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Department
{
    
    class FireTruck
    /// <summary>
    /// Implements Fire Truck containing Ladder , Hose pipe and driver
    /// </summary>
    {
        // attributes
        public Ladder ladder;
        public Hosepipe hosepipe;
        public Firefighter Firefighter = null;

        // constructor 
        public FireTruck(Ladder ladder)
        {
            this.ladder = ladder;
        }
        
        // assigns Firefighter and takes Firefighter as parameter
        public void Assign_FireFighter(Firefighter firefighter)
        {
            if (firefighter != null)
            {
                this.Firefighter = firefighter;

            }
        }

        public void Attach_Hosepipe(Hosepipe hosepipe)
        {
            this.hosepipe = hosepipe;
        }
    }
}
