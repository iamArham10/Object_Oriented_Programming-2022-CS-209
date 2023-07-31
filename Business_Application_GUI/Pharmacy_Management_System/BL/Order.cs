using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.BL
{
    public class Order
    {
        public DateTime ordertime;
        public List<Medicine> products = new List<Medicine>(); 
        public Order() { }

        public List<Medicine> Products { get { return products; } set => this.products = value; }
        
        public float Get_Total_Price()
        {
            int price = 0;
            foreach(var item in products)
            {
                price += item.Price * item.Quantities;
            }
            return price;
        }

        public bool Add_Product(Medicine product)
        {
            foreach(Medicine m in  products)
            {
                if (m.Name == product.Name && m.Weight == product.Weight) 
                {
                    return false;
                }
            }
            products.Add(product);
            return true;
        }

        public bool Remove_Product(Medicine product)
        {
            foreach(Medicine m in products)
            {
                if (m.Name == product.Name && m.Weight == product.Weight)
                {
                    products.Remove(m);
                    return true;
                }
            }
            return false;
        }
        
        public void Clear_Order()
        {
            products = new();
        }
    }
}
