using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departmental_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>(); // list of products added in inventory
            List<User> users = new List<User>(); // list of users stored in list
            List<Customer> customers = new List<Customer>();
            char option;
            do
            {
                Console.Clear();
                option = Main_menu();
                if (option == '1') // Sign in 
                {
                    Console.Clear();
                    Console.WriteLine("SignIn Option");
                    User user = Take_SignIn_Input(users);

                    if (user != null)
                    {
                        if (user.Is_Admin())
                        {
                            do
                            {
                                Console.Clear();
                                option = Admin_Menu();
                                if (option == '1')
                                {
                                    Console.Clear();
                                    products.Add(Create_Product());
                                    products = products.OrderByDescending(o => o.Return_Price()).ToList();
                                }
                                else if (option == '2')
                                {
                                    Console.Clear();
                                    View_Products(products);
                                    Console.ReadKey();
                                }
                                else if (option == '3')
                                {
                                    Console.Clear();
                                    Print_Product_Info(products[0]);
                                    Console.ReadKey();
                                }
                                else if (option == '4')
                                {
                                    Console.Clear();
                                    View_Sales_Tax(products);
                                    Console.ReadKey();
                                }
                                else if (option == '5')
                                {
                                    Console.Clear();
                                    View_Products_To_Be_Ordered(products);
                                    Console.ReadKey();
                                }
                            } while (option != '6');
                        }
                        else
                        {
                            Customer customer = Return_Customer(customers, user.username); // returns shallow copy of customer present in list
                            do
                            {
                                Console.Clear();
                                option = Customer_Menu();
                                if (option == '1')
                                {
                                    Console.Clear();
                                    View_Products(products);
                                    Console.ReadKey();
                                }
                                else if (option == '2')
                                {
                                    Console.Clear();
                                    Console.WriteLine("..Buy Product..");
                                    Console.WriteLine("Enter Product Name: ");
                                    string Product_Name = Console.ReadLine();
                                    Product Product = Is_Product_Present(Product_Name, products);
                                    if (Product != null)
                                    {
                                        Product.Decrease_Quantity(1);
                                        customer.Add_Product(Product_Name);
                                        Console.WriteLine("Product Added");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Product Was Not Present.");
                                    }
                                    Console.ReadKey();
                                }
                                else if (option == '3')
                                {
                                    Console.WriteLine("InVoice");
                                    double total = Print_Customer_Products(products, customer.Return_Products());
                                    Console.WriteLine($"Your total is {total}");
                                    Console.WriteLine("Press Any key TO EXit");
                                    Console.ReadKey();
                                }
                            } while (option != '4');
                        }
                    }
                    else
                    {
                        Console.WriteLine("User Is Not Present");
                    }

                }

                else if (option == '2') // sign up
                {
                    Console.Clear();
                    Console.WriteLine("SignUp Option");
                    User newuser = Take_Signup_Input();
                    users.Add(newuser);
                    if (!newuser.Is_Admin())
                    {
                        Customer newCustomer = new Customer(newuser.username);
                        customers.Add(newCustomer);
                    }
                }

            } while (option != '0');
        }

        static char Main_menu() // main menu option
        {
            char option;
            Console.WriteLine("Press Any Of The Following Option.");
            Console.WriteLine("\t1.SignIn.");
            Console.WriteLine("\t2.SignUp.");
            Console.WriteLine("\t0.Exit.");
            option = char.Parse(Console.ReadLine());
            return option;
        }

        static char Admin_Menu() // admin menu
        {
            Console.WriteLine("Admin Menu");
            Console.WriteLine("Press The Following Options");
            Console.WriteLine("\t1.Add Product");
            Console.WriteLine("\t2.View Product");
            Console.WriteLine("\t3.Find Product With Highest Unit Price.");
            Console.WriteLine("\t4.View Sales Tax Of All products.");
            Console.WriteLine("\t5.Products To Be Ordered.");
            Console.WriteLine("\t0.Exit.");
            char option = char.Parse(Console.ReadLine());
            return option;
        }

        static char Customer_Menu() // Customer Menu
        {
            Console.WriteLine("Customer Menu");
            Console.WriteLine("Press the Following Options");
            Console.WriteLine("\t1.View All The Products.");
            Console.WriteLine("\t2.Buy The Products.");
            Console.WriteLine("\t3.Generate Invoice");
            Console.WriteLine("\t0.Exit");
            char option = char.Parse(Console.ReadLine());
            return option;
        }

        static User Take_SignIn_Input(List<User> users) // takes username and password from user 
        {
            string username, userpassword;
            Console.WriteLine("Enter User Name : ");
            username = Console.ReadLine();
            Console.WriteLine("Enter User Passcode: ");
            userpassword = Console.ReadLine();
            User user = new User(username, userpassword); // creates  a new user with username and password
            user = IsUserPresent(users, user); // if user is in list user is returned else null is returned
            return user;
        }

        static User Take_Signup_Input() // user input for signup and returns a user
        {
            string username, userpassword;
            char usertype;
            Console.WriteLine("Enter User Name : ");
            username = Console.ReadLine();
            Console.WriteLine("Enter User Passcode: ");
            userpassword = Console.ReadLine();
            Console.WriteLine("Enter Role Customer(C) or Admin(A)");
            usertype = char.Parse(Console.ReadLine());
            User newuser = new User(username, userpassword, usertype);
            return newuser;
        }

        static User IsUserPresent(List<User> users, User user) // checks if the user is present returns
        {                                                      // user in list if user in parameter is present in list
            foreach (User currentuser in users)
            {
                if (currentuser.username == user.username)
                {
                    if (currentuser.passcode == user.passcode)
                    {
                        return currentuser;
                    }
                }
            }
            return null; // returns null if user is not present 
        }

        static Product Create_Product() // inputs product information from user and returns the product object
        {
            string name; char category; int price; int stockquantity; int threshold;
            Console.WriteLine("Enter Product Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Category Of the Product F for Fruit G for Grocery or any: ");
            category = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price Of the Product: ");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Stock Quantity: ");
            stockquantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Stock threshold : ");
            threshold = int.Parse(Console.ReadLine());
            Product new_product = new Product(name, category, price, stockquantity, threshold);
            return new_product;
        }

        static void View_Products(List<Product> products) // view product option prints all products 
        {                                                 // present in the list
            Console.WriteLine("..View Products..");
            foreach (Product currentproduct in products)
            {
                Print_Product_Info(currentproduct);
                Console.WriteLine();
            }
        }

        static void Print_Product_Info(Product product) // prints product info
        {
            Console.WriteLine($"Name : {product.Product_Name}");
            Console.WriteLine($"Price : {product.Product_Price}");
            Console.WriteLine($"Category : {product.Product_Category}");
            Console.WriteLine($"Quantity : {product.Stock_Quantity}");
        }

        static void View_Sales_Tax(List<Product> products) // prints sales tax of all product in list
        {
            Console.WriteLine("..Sales Tax..");
            foreach (Product product in products)
            {
                double sales_tax = (product.Sale_Tax()) * product.Return_Stock();
                Console.WriteLine($"Name : {product.Product_Name} : {sales_tax}");
            }
        }

        static void View_Products_To_Be_Ordered(List<Product> products) // prints product info whose isquantityfunction returns true
        {
            foreach (Product product in products)
            {
                if (product.Is_Quantity_Less())
                {
                    Print_Product_Info(product);
                    Console.WriteLine();
                }
            }
        }

        static Product Is_Product_Present(string product, List<Product> products) // returns true if entered product name is present in Product list as attribute of product
        {
            bool ispresent = false;
            foreach (Product currentproduct in products)
            {
                if (currentproduct.Product_Name == product)
                {
                    return currentproduct;
                }
            }
            return null;
        }

        static Customer Return_Customer(List<Customer> customers, string username) // return shallow copy of customer if there is  customer with username
        {
            foreach (Customer customer in customers)
            {
                if (customer.username == username)
                {
                    return customer;
                }
            }
            return null;
        }

        static double Print_Customer_Products(List<Product> products, List<String> product_names)
        {
            double total = 0;
            foreach (string product_name in product_names)
            {
                foreach (Product product in products)
                {
                    if (product.Product_Name == product_name)
                    {
                        double price = product.Product_Price + product.Sale_Tax();
                        Console.WriteLine($"Product Name : {product.Product_Name} : Price : {price}");
                        total += price;
                    }
                }
            }
            return total;
        }
    }
}
