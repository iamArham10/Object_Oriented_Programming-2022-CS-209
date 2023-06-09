using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_1
{
    class CoffeeShopUI
    {
        public static void Take_Input(CoffeeShop cs)
        {
            Console.WriteLine("Enter Order: ");
            string input = Console.ReadLine();
            if (cs.Add_Order(input))
            {
                Console.WriteLine("Order Added Succesfully");
            }
            else
            {
                Console.WriteLine("Not Available");
            }
        }

        public static void Print_Fulfilled_Order(string Order)
        {
            if (Order != "Null")
            {
                Console.WriteLine($"The Item {Order} is served");
            }
            else
            {
                Console.WriteLine($"All Items Are Served");
            }
        }

        public static void Print_List_Orders(List<string> orders)
        {
            if (orders.Count > 0)
            {
                foreach(string order in orders)
                {
                    Console.WriteLine(order);
                }
            }
            else
            {
                Console.WriteLine("No Order");
            }
        }

        public static void Print_Price(int price)
        {
            Console.WriteLine("Total Price Is {0}",price);
        }
    }
}
