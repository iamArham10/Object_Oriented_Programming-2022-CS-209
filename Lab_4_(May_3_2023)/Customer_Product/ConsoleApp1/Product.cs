using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        // attributes
        public string Name;
        public string Category;
        public int Price;

        // constructor
        public Product(string name, string category, int price)
        {
            this.Name = name;
            this.Category = category;
            this.Price = price;
        }

        public Product(Product p) // copy constructor 
        {
            this.Name = p.Name;
            this.Category = p.Category;
            this.Price = p.Price;
        }
        // method
        public float CalculateTax() // returns tax on the product
        {
            float tax = Price*1.5F;
            return tax;
        }
    }
}
