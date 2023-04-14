using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Products[] pd = new Products[1000];
            int count = 0;
            char option;
            do
            {
                Console.Clear();
                option = Main_menu();
                if (option == '1')
                {
                    pd[count] = Add_Product();
                    count++;
                }
                else if (option == '2')
                {
                    View_Products(pd, count);
                    Console.ReadKey();
                }
                else if (option == '3')
                {
                    Show_Store_Wroth(pd, count);
                    Console.ReadKey();
                }
            } while (option != '4');
        }


        static char Main_menu()
        {
            char option;
            Console.WriteLine("Enter The Following Options: ");
            Console.WriteLine("1  <->  Add Products      <->");
            Console.WriteLine("2  <->  Show Products     <->");
            Console.WriteLine("3  <->  Total Store Worth <->");
            option = char.Parse(Console.ReadLine());
            return option;
        }

        static Products Add_Product()
        {
            Products temp = new Products();
            Console.WriteLine("Enter Name of the Product: ");
            temp.name = Console.ReadLine();
            Console.WriteLine("Enter ID of the Product: ");
            temp.ID = Console.ReadLine();
            Console.WriteLine("Enter Price of the Product: ");
            temp.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Category of the Product: ");
            temp.category = Console.ReadLine();
            Console.WriteLine("Enter Brand of the Product: ");
            temp.brand = Console.ReadLine();
            Console.WriteLine("Enter Country of the Product: ");
            temp.country = Console.ReadLine();
            return temp;
        }

        static void View_Products(Products[] p, int count)
        {
            Console.Clear();
            for (int product = 0; product < count; product++)
            {
                Console.WriteLine("Name : {0} ID : {1} Price : {2} Category : {3} Brand : {4} Country : {5}", p[product].name, p[product].ID, p[product].price, p[product].category, p[product].brand, p[product].country);
            }
        }

        static void Show_Store_Wroth(Products[] p, int count)
        {
            int Worth = Calculate_Worth(p, count);
            Console.Clear();
            Console.WriteLine("The Total Worth of Store : {0}", Worth);
        }

        static int Calculate_Worth(Products[] p, int count)
        {
            int worth = 0;
            for (int product = 0; product < count; product++)
            {
                worth += p[product].price;
            }
            return worth;
        }
    } 
}
