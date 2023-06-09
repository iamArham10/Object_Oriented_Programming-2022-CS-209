using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departmental_Store
{
    class Product
    {
        // attributes
        public string Product_Name;
        public char Product_Category;
        public int Product_Price;
        public int Stock_Quantity;
        public int Minimum_Threshold;
        // constructor
        public Product(string PN, char PC, int PP, int SQ, int MT)
        {
            Product_Name = PN;
            Product_Category = PC;
            Product_Price = PP;
            Stock_Quantity = SQ;
            Minimum_Threshold = MT;
        }
        // methods
        public int Return_Price() // returns the price of the product
        {
            return Product_Price;
        }
        public bool Is_Quantity_Less() // returns true if product Quantity is less or equal to threshold
        {
            bool isLess = false;
            if (Stock_Quantity <= Minimum_Threshold)
            {
                isLess = true;
            }
            return isLess;
        }
        public void Decrease_Quantity(int noofquantity) // decreases the stock quantity of product
        {
            this.Stock_Quantity -= noofquantity;
        }
        public int Return_Stock() // returns no of quantities of product
        {
            return Stock_Quantity;
        }
        public double Sale_Tax ()
        {
            int tax_p = 15;
            if (Product_Category == 'G')
            {
                tax_p = 10;
            }
            else if (Product_Category == 'F')
            {
                tax_p = 5;
            }
            return (float)((Product_Price * tax_p) / 100);
        }
    }
}
