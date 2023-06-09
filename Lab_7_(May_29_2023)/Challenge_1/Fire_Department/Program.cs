using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Department
{
    class Program
    {
        static void Main(string[] args)
        {
            char option;
            do
            {
                option = MainUI.Main_Menu();
                if (option == '1')
                {
                    Firefighter firefighter = FireFighterUI.Create_FireFighter();
                    if (firefighter != null)
                    {
                        FireFighterDL.Add_Firefighter(firefighter); // adds firefighter to firefighter list in DL class
                    }
                    MainUI.Clear_Screen();
                }
                if (option == '2')
                {
                    // prints all firefighter object attribute name
                    FireFighterUI.Print_FireFighters(FireFighterDL.Fire_Fighters);
                    // Get's firefighter name from user and creates a firefighter
                    Firefighter firefighter = FireFighterUI.Get_FireFighter();
                    FireTruck firetruck = FireTruckUI.Create_Fire_Truck();
                    firetruck.Attach_Hosepipe(HosepipeUI.Create_Hosepipe());
                    firetruck.Assign_FireFighter(firefighter);
                    MainUI.Clear_Screen();
                }
            } while (option != '0');
        }
    }
}
