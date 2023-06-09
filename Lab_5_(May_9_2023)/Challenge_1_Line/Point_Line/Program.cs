using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLine Current_Line = null;
            char option;
            do
            {
                Console.Clear();
                option = Main_Menu();
                if (option == '1')
                {
                    Console.Clear();
                    Console.WriteLine("Begin Point : ");
                    MyPoint Begin = GetPoint();
                    Console.WriteLine("End Point : ");
                    MyPoint End = GetPoint();
                    Current_Line = new MyLine(Begin, End);
                    Console.WriteLine("Line Created Succesfully");
                    Console.WriteLine("Press Any key to Continue..");
                    Console.ReadKey();
                }
                else if (option == '2')
                {
                    Console.Clear();
                    if (Current_Line == null)
                    {
                        Console.WriteLine("No Line Created");
                    }
                    else
                    {
                        Console.WriteLine("Update Begin Point Option");
                        MyPoint Begin = GetPoint();
                        Current_Line.Set_Begin(Begin);
                    }
                    Console.ReadKey();
                }
                else if (option == '3')
                {
                    Console.Clear();
                    if (Current_Line == null)
                    {
                        Console.WriteLine("No Line Created");
                    }
                    else
                    {
                        Console.WriteLine("Update End Point Option");
                        MyPoint End = GetPoint();
                        Current_Line.Set_End(End);
                    }
                    Console.ReadKey(); 
                }
                else if (option == '4')
                {
                    Console.Clear();
                    if (Current_Line == null)
                    {
                        Console.WriteLine("No Line Created");
                    }
                    else
                    {
                        
                        Console.WriteLine("Begin Point Position");
                        Console.WriteLine(Return_Position(Current_Line.Get_Begin()));
                    }
                    Console.ReadKey();
                }
                else if (option == '5')
                {
                    Console.Clear();
                    if (Current_Line == null)
                    {
                        Console.WriteLine("No Line Created");
                    }
                    else
                    {
                        Console.WriteLine("End Point Position");
                        Console.WriteLine(Return_Position(Current_Line.Get_End()));
                    }
                    Console.ReadKey();
                }
                else if (option == '6')
                {
                    Console.Clear();
                    if (Current_Line == null)
                    {
                        Console.WriteLine("No Line Created");
                    }
                    else
                    {
                        double length = Current_Line.Get_Length();
                        Console.WriteLine("The Length of the line is {0}", length);
                    }
                    Console.ReadKey();
                }
                else if (option == '7')
                {
                    Console.Clear();
                    if (Current_Line == null)
                    {
                        Console.WriteLine("No Line Created");
                    }
                    else
                    {
                        double gradient = Current_Line.Get_Gradient();
                        Console.WriteLine("The Gradient Of the Line is {0}", gradient);
                    }
                    Console.ReadKey();
                }
                else if (option == '8')
                {
                    Console.Clear();
                    if (Current_Line == null)
                    {
                        Console.WriteLine("No Line Created");
                    }
                    else
                    {
                        MyPoint Begin = Current_Line.Get_Begin();
                        double distance = Begin.Distance_From_Zero();
                        Console.WriteLine("The Distance of Begin point from origin is {0}", distance);
                    }
                    Console.ReadKey();
                }
                else if (option == '9')
                {
                    Console.Clear();
                    if (Current_Line == null)
                    {
                        Console.WriteLine("No Line Created");
                    }
                    else
                    {
                        MyPoint End = Current_Line.Get_End();
                        double distance = End.Distance_From_Zero();
                        Console.WriteLine("The Distance of End point from origin is {0}", distance);
                    }
                    Console.ReadKey();
                }
            } while (option != '0');

        }

        static char Main_Menu() // prints the options and get option input from user
        {
            char option;
            Console.WriteLine("Press Any Of The Options: ");
            Console.WriteLine("\t1.Make A Line.");
            Console.WriteLine("\t2.Update The Begin Point.");
            Console.WriteLine("\t3.Update The End Point.");
            Console.WriteLine("\t4.Show The Begin Point.");
            Console.WriteLine("\t5.Show The End Point.");
            Console.WriteLine("\t6.Get The Length Of the Line.");
            Console.WriteLine("\t7.Get The Gradient Of The Line.");
            Console.WriteLine("\t8.Find The Distance Of Begin Point From Origin.");
            Console.WriteLine("\t9.Find The Distance Of End Point From Origin.");
            Console.WriteLine("\t0.Exit.");
            option = char.Parse(Console.ReadLine());
            return option;
        }

        static MyPoint GetPoint() // inputs x and y coordiantes from user and returns a new point
        {
            Console.WriteLine("Enter X Coordinate : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y Coordinate : ");
            int y = int.Parse(Console.ReadLine());
            MyPoint newpoint = new MyPoint(x, y);
            return newpoint;
        }

        static string Return_Position(MyPoint point) // returns position of point in string
        {
            int point_x = point.GetX();
            int point_y = point.GetY();
            string position = $"The Point is At Coordinates ({point_x},{point_y})";
            return position;
        }
    }
}
