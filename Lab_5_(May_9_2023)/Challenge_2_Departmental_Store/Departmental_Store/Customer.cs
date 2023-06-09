using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departmental_Store
{
    class Customer
    {
        // attributes
        public string username;
        public List<string> products = new List<string>();
        // constructor
        public Customer(string name)
        {
            username = name;
        }
        // methods
        public void Add_Product(string product) // adds product to the product list
        {
            products.Add(product);
        }
        public List<string> Return_Products() // returns the list of customer products
        {
            return products;
        }
        public void Clear_Products()
        {
            products = new List<string>();
        }
        
    }
}
