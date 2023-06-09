using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Department
{
    class FireFighterDL
    {
        /// <summary>
        /// contains list of firefighters and functions related to list of firefighters
        /// </summary>

        // list containing all firefighters objects
        public static List<Firefighter> Fire_Fighters = new List<Firefighter>(); 

        // adds fireifighter to firefighters list
        static public void Add_Firefighter(Firefighter firefighter) // 
        {
            if (!(Fire_Fighters.Contains(firefighter)))
            {
                Fire_Fighters.Add(firefighter);
            }
        }

        // returns the firefighter object from list who's name attribute matches given string
        static public Firefighter Get_Firefighter(string firefightername)
        {
            Firefighter matchedfirefighter = null;
            foreach (Firefighter firefighter in Fire_Fighters)
            {
                if (firefighter.name == firefightername)
                {
                    matchedfirefighter = firefighter;
                    break;
                }
            }
            return matchedfirefighter;
        }

        static public void Print_FireFighters(List<Firefighter> Fire_Fighers)
        {
            foreach(Firefighter firefighter in Fire_Fighters)
            {
                Console.WriteLine(firefighter.name);
            }
        }
    }
}
