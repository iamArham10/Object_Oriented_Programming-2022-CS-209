using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer
    {
        // attributes
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerContact;
        public List<Product> products = new List<Product>();

        // constructor
        public Customer(string name, string address, string contact)
        {
            CustomerName = name;
            CustomerAddress = address;
            CustomerContact = contact;
        }

        // methods
        public List<Product> GetAllProducts() // returns the list of all of the products
        {
            return products;
        }

        public void AddProduct(Product p) // adds the product to the list of customer products
        {
            products.Add(p);
        }

        public float Total_Purchase()
        {
            float total = 0F;
            foreach(Product product in products)
            {
                total += product.Price;
            }
            return total;
        }

        public float Total_tax()
        {
            float total = 0F;
            foreach(Product product in products)
            {
                total += product.CalculateTax();
            }
            return total;
        }
    }
}
