using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            char option;
            do
            {
                Console.Clear();
                option = Menu();
                if (option == '1')
                {
                    Console.Clear();
                    Product product = Get_Product();
                    products.Add(product);
                    Console.WriteLine("Press Any Key To Continue..");
                    Console.ReadKey();
                }
                else if (option == '2')
                {
                    Console.Clear();
                    Customer_Order(products);
                    Console.WriteLine("Press Any key To Continue..");
                    Console.ReadKey();
                }
            } while (option != '3');
        }

        static char Menu() // prints the main menu options and also takes input from user and returns it
        {
            Console.WriteLine("Enter the following options");
            Console.WriteLine("1. Add a Product");
            Console.WriteLine("2. Take Order");
            char option = char.Parse(Console.ReadLine());
            return option;
        }

        static void Get_Products(int noofProducts,Customer newcustomer, List<Product> products) // get all of the product from the user
        {
            for(int current_product = 0; current_product < noofProducts; current_product++)
            {
                Console.WriteLine("Product no {0}", current_product+1);
                string productname = Console.ReadLine();
                Product product = Get_Product_From_Name(products , productname);
                if (product != null)
                {
                    newcustomer.AddProduct(product);
                }
            }
        }

        static Product Get_Product_From_Name(List<Product> products, string pname)
        {
            foreach(Product product in products)
            {
                if (product.Name == pname)
                {
                    Product newproduct = new Product(product); // copies all of the product attributes to the new product that can be saved in customers list
                    return newproduct;
                }
            }
            return null;
        }

        static Product Get_Product() // inputs all of the product attributes from the user creates a product and returns is
        {
            Console.WriteLine("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Product Category: ");
            string category = Console.ReadLine();
            Console.WriteLine("Enter Product Price: ");
            int price = int.Parse(Console.ReadLine());
            Product product = new Product(name, category, price);
            return product;
        }

        static void Customer_Order(List<Product> storeproducts)
        {
            Console.WriteLine("Enter Customer Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Customer's Adress: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Customers Contact: ");
            string contact = Console.ReadLine();
            Customer newcustomer = new Customer(name, address, contact);
            Console.WriteLine("Enter Number of Products you want to buy: ");
            int noofproducts = int.Parse(Console.ReadLine());
            Get_Products(noofproducts, newcustomer, storeproducts);
            float customer_Total_Purchase = newcustomer.Total_Purchase();
            float customer_Total_Tax = newcustomer.Total_tax();
            Console.WriteLine("Your Total Purchase Amount is " + customer_Total_Purchase);
            Console.WriteLine("Total Tax on your Purchases is " + customer_Total_Tax);
            float total = customer_Total_Purchase + customer_Total_Tax;
            Console.WriteLine("The Total You have to pay is " + total);
        }
    }
}
