using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_two
{
    class Program
    {
        static void Main(string[] args)
        {

            Product MyProducts = new Product();
            char option;
            do
            {
                Console.Clear();
                option = Main_Menu();

                if (option == '1')
                {
                    Console.Clear();
                    string Product_name;
                    char Product_Category;
                    int Product_Price;
                    int Product_StockQuantity;
                    int Product_MinimumStockQuantity;
                    Console.WriteLine("Enter Product Name: ");
                    Product_name = Console.ReadLine();
                    Console.WriteLine("Enter Product Category: ");
                    Product_Category = char.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Product Price: ");
                    Product_Price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Stock Quantity: ");
                    Product_StockQuantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Minimum Stock Quantity: ");
                    Product_MinimumStockQuantity = int.Parse(Console.ReadLine());
                    MyProducts.Add_Product(Product_name, Product_Category, Product_Price, Product_StockQuantity, Product_MinimumStockQuantity);
                    Console.Clear();
                    Console.WriteLine("Product Added Succesfully, Press any key to continue");
                    Console.ReadKey();
                }
                else if (option == '2')
                {
                    Console.Clear();
                    MyProducts.View_Products();
                    Console.ReadKey();
                }
                else if (option == '3')
                {
                    Console.Clear();
                    Product Valuable_Product = new  Product(MyProducts.Highest_Price());
                    Console.WriteLine("Name " + Valuable_Product.Name);
                    Console.WriteLine("Price " + Valuable_Product.Price);
                    Console.WriteLine("Quantity " + Valuable_Product.Stock_Quantity);
                    Console.ReadKey();
                }
                else if (option == '4')
                {
                    Console.Clear();
                    MyProducts.Print_Tax();
                    Console.ReadKey();
                }
                else if (option == '5')
                {
                    Console.Clear();
                    MyProducts.Products_To_Be_Ordered();
                    Console.ReadKey();
                }

            } while (option != '0');


        }

        static char Main_Menu()
        {
            char option;
            Console.WriteLine("Departmental Store Management");
            Console.WriteLine("1. Add Product.");
            Console.WriteLine("2. View All Products.");
            Console.WriteLine("3. Most Valuable Product.");
            Console.WriteLine("4. Sales Tax Of All Product.");
            Console.WriteLine("5. Products To Be Ordered.");
            Console.WriteLine("0. Exit.");
            option = char.Parse(Console.ReadLine());
            return option;
        }

    }
}
