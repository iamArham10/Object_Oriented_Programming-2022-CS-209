using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Angle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ship> ships = new List<Ship>();
            char option;
            do
            {
                option = menu();
                if (option == '1')
                {
                    Console.Clear();
                    Ship newship = Add_Ship();
                    ships.Add(newship);

                }
                else if (option == '2')
                {
                    Console.Clear();
                    Console.WriteLine("Enter Ship serial Number: ");
                    string ship_number = Console.ReadLine();
                    Ship viewship = View_Ship(ship_number, ships);
                    Print_Ship_Location(viewship);
                }
                else if (option == '3')
                {
                    Console.Clear();
                    Console.WriteLine("Enter Ship Locations: ");
                    Angle Longitudnal = Get_Angle("Longitudnal");
                    Angle Latitudenal = Get_Angle("Latitudenal");
                    string shipID = Get_Ship(Longitudnal, Latitudenal, ships);
                    if (shipID != null)
                    {
                        Console.WriteLine("Ships Location is in {0}", shipID);
                    }
                }
                else if (option == '4')
                {
                    Console.WriteLine("Enter Ships SErial Number: ");
                    string ships_Serial_number = Console.ReadLine();
                    Ship changed_ship = View_Ship(ships_Serial_number, ships);
                    Change_Direction(changed_ship);
                }
            } while (option != '5');
        }

        static char menu()
        {
            char option;
            Console.WriteLine("Enter Any of the following options: ");
            Console.WriteLine("Add Ship");
            Console.WriteLine("View Ship Position");
            Console.WriteLine("View Ship Serial Number");
            Console.WriteLine("Change Ship Position");
            Console.WriteLine("Exit");
            option = char.Parse(Console.ReadLine());
            return option;
        }

        static Ship Add_Ship()
        {
            Console.WriteLine("Enter Ship Number: ");
            string Ship_Number = Console.ReadLine();
            Angle Longitude = Get_Angle("Longitude");
            Angle Latitude = Get_Angle("Latitude");
            Ship newship = new Ship(Ship_Number, Longitude, Latitude);
            return newship;
        }

        static void Change_Direction(Ship ship)
        {

            ship.Longitude = Get_Angle("Longitude");
            ship.Latitude = Get_Angle("Latitude");
        }

  
        static string Get_Ship(Angle Longitudenal, Angle Latitudenal, List<Ship> ships)
        {
            foreach (Ship ship in ships)
            {
                if ((Longitudenal.Degree == ship.Longitude.Degree) && (Longitudenal.Minutes == ship.Longitude.Minutes) && (Longitudenal.Direction == ship.Longitude.Direction))
                {
                    if ((Latitudenal.Degree == ship.Latitude.Degree) && (Latitudenal.Minutes == ship.Latitude.Minutes) && (Latitudenal.Direction == ship.Latitude.Direction))
                    {
                        return ship.ship_number;
                    }
                }
            }
            return null;
        }

        static Ship View_Ship(string ship_number, List<Ship> ships)
        {
            foreach(Ship ship in ships)
            {
                if (ship_number == ship.Return_Serial_Number())
                {
                    return ship;
                }
            }
            return null;
        }

        static Angle Get_Angle(string Navigation)
        {
            int Degree_Threshold;
            if (Navigation == "Longitude")
            {
                Degree_Threshold = 180;
            }
            else
            {
                Degree_Threshold = 90;
            }
            Console.WriteLine("Enter Ship {0}", Navigation);
            Console.WriteLine("Enter Ships {0} Degree: ", Navigation);
            int Degree = int.Parse(Console.ReadLine());
            while (Degree > Degree_Threshold)
            {
                Console.WriteLine("Enter Ships {0} Degree: ", Navigation);
                Degree = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Ships {0 } minutes: ", Navigation);
            float minutes = float.Parse(Console.ReadLine());
            if (Degree == Degree_Threshold)
            {
                while (minutes != 0)
                {
                    Console.WriteLine("Enter Ships {0 } minutes: ", Navigation);
                    minutes = float.Parse(Console.ReadLine());
                }
            }
            else
            {
                while (minutes > 60)
                {
                    Console.WriteLine("Enter Ships {0} minutes: ", Navigation);
                    minutes = float.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter Ships {0} Direction: ", Navigation);
            char Direction = char.Parse(Console.ReadLine());

            Angle newangle = new Angle(Degree, minutes, Direction);
            return newangle;
        }

        static void Print_Ship_Location(Ship ship)
        {
            string longitudnal_location = ship.Longitude.return_Location();
            string latitudenal_location = ship.Latitude.return_Location();
            Console.WriteLine("Ship is at {0} and  {1}", longitudnal_location, latitudenal_location);
        }
    }
}
