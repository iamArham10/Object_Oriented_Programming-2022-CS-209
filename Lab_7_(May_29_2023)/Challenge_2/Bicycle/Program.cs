using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle
{
    class Program
    {
        static void Main(string[] args)
        {
            char option;
            Bicycle bicycle = null;
            do
            {
                option = DriverUI.Main_Menu();
                if (option == '1')
                {
                    DriverUI.Clear_Screen();
                    bicycle = BicycleUI.Create_Bicycle();
                    DriverUI.Clear_Screen();

                }
                else if (option == '2')
                {
                    DriverUI.Clear_Screen();
                    int cadence = DriverUI.Get_Integer("Enter Cadence");
                    if (bicycle != null)
                    {
                        bicycle.Set_Cadence(cadence);
                    }
                    DriverUI.Clear_Screen();

                }
                else if (option == '3')
                {
                    DriverUI.Clear_Screen();
                    int gear = DriverUI.Get_Integer("Enter Gear");
                    if (bicycle != null)
                    {
                        bicycle.Set_Gear(gear);
                    }
                    DriverUI.Clear_Screen();

                }
                else if (option == '4')
                {
                    DriverUI.Clear_Screen();
                    int breakdecrement = DriverUI.Get_Integer("Enter Amount of Decrement to Speed");
                    if (bicycle != null)
                    {
                        bicycle.Apply_Break(breakdecrement);
                    }
                    DriverUI.Clear_Screen();

                }
                else if (option == '5')
                {
                    DriverUI.Clear_Screen();
                    if (bicycle != null)
                    {
                        int increment = DriverUI.Get_Integer("Enter speed you want to increment");
                        bicycle.Speed_Up(increment);
                    }
                    DriverUI.Clear_Screen();

                }
                else if (option == '6')
                {
                    DriverUI.Clear_Screen();
                    if (bicycle != null)
                    {
                        BicycleUI.Print_Bicycle_State(bicycle);
                    }
                    DriverUI.Clear_Screen();
                }
            } while (option != '0');
        }
    }
}
