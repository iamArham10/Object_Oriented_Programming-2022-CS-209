using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Department
{
    /// <summary>
    /// 
    /// </summary>
    class FireFighterUI
    {
        static public Firefighter Create_FireFighter() // Creates a firefighter with user inputted name
                                                       // and returns it as an object
        {
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Firefighter new_fighter = new Firefighter(name);
            return new_fighter;
        }
        
        static public FireChief Create_FireCheif()    // Creates a Firechief with user inputted name
                                                      // and returns it as an object
        {
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            FireChief newfirechief = new FireChief(name);
            return newfirechief;
        }

        static public Firefighter Get_FireFighter()
        {
            Console.WriteLine("Enter Firfighter Name : ");
            string name = Console.ReadLine();
            Firefighter firefighter = FireFighterDL.Get_Firefighter(name);
            return firefighter;
        }

        static public void Print_FireFighters(List<Firefighter> Fire_Fighters)
        {
            foreach (Firefighter firefighter in Fire_Fighters)
            {
                Console.WriteLine(firefighter.name);
            }
        }
    }
}
