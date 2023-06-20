using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StaffUI
    {
        public static Staff Create_Staff()
        {
            Console.WriteLine("Enter Staff Information : ");
            string name;
            string address;
            string school;
            double pay;
            Console.Write("Enter Name ");
            name = Console.ReadLine();
            Console.Write("Enter Adress : ");
            address = Console.ReadLine();
            Console.Write("Enter School : ");
            school = Console.ReadLine();
            Console.Write("Enter Pay : ");
            pay = double.Parse(Console.ReadLine());
            Staff Newstaff = new Staff(name, address, school, pay);
            return Newstaff;
        }
    }
}
