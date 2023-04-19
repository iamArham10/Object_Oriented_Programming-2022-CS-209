using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_two
{
    class Product // Creating a product class
    {  
        public string Name;
        public char Category;
        public int Price;
        public int Stock_Quantity;
        public int Minimum_Stock_Quantity;
        public List<Product> Products = new List<Product>();

        // Constructor that will copy the product
        public Product(Product p)
        {
            Name = p.Name;
            Category = p.Category;
            Price = p.Price;
            Stock_Quantity = p.Stock_Quantity;
            Minimum_Stock_Quantity = p.Minimum_Stock_Quantity;
        }

        // Empty Constructor in case we don't want any parameter to be passed
        public Product() { }

        // to Add Product to the Products List.
        public void Add_Product(string name, char category, int price, int stockquantity,int minimum_stock_quantity)
        {
            Product NewProduct = Create_Product(name, category, price, stockquantity, minimum_stock_quantity);
            Products.Add(NewProduct);
        }

        // Returns True if the Product name entered is already present as an attribute of objects present in the list
        public bool IsProductPresent(string name)
        {
            foreach (Product product in Products)
            {
                if (product.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void Print_Tax()
        {
            foreach (Product product in Products)
            {
                float tax = Calculate_Tax(product);
                Console.WriteLine("Tax On the Product " + product.Name + " " + tax);
            }
        }

        public float Calculate_Tax(Product product)
        {
            float tax;
            if (product.Category == 'F')
            {
                tax = (product.Price * 10) / 100;
            }
            else
            {
                tax = (product.Price * 15) / 100;
            }
            return tax;
        }

        // Prints about the Products that are about to be ordered
        public void Products_To_Be_Ordered()
        {
            foreach (Product product in Products)
            {
                if (product.Stock_Quantity < product.Minimum_Stock_Quantity)
                {
                    Console.WriteLine(product.Name);
                }
            }
        }
   
        // Returns The Highest Price Product
        public Product Highest_Price()
        {
            
            int Highest_price_index = Highest_Price_Index();
            Product Valuable_Product = new Product(Products[Highest_price_index]);
            return Valuable_Product;
        }

        // returns the highest_Price_index;
        public int Highest_Price_Index()
        {
            int index = 0;
            int previous_price = -1;
            for (int product_no = 0; product_no < Products.Count; product_no++)
            {
                if (previous_price < Products[product_no].Price)
                {
                    index = product_no;
                }
            }
            return index;
        }

        // This function creates a temporary product variable and stores all the attributes passed to it and them returns the object
        public Product Create_Product(string name, char category, int price, int stockquantity, int minimum_stock_quantity)
        {
            Product NewProduct = new Product();
            NewProduct.Name = name;
            NewProduct.Category = category;
            NewProduct.Price = price;
            NewProduct.Stock_Quantity = stockquantity;
            NewProduct.Minimum_Stock_Quantity = minimum_stock_quantity;
            return NewProduct;
        }

        // This Function is used to view products
        public void View_Products()
        {
            foreach(Product product in Products)
            {
                Console.WriteLine("Name :" + product.Name + " | Category: " + product.Category + " | Price: " + product.Price + " | Stock Quantity : " + product.Stock_Quantity + " | Minimum Stock Quantity: " + product.Minimum_Stock_Quantity);
            }
        }
    }
    
}
