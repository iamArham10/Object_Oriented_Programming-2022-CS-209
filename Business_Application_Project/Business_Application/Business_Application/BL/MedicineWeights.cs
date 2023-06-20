using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application
{
    public class MedicineWeight
    /// <summary>
    /// is an instance of medicine that'll contain weight and quantity of medicine
    /// </summary>
    {
        // atributes
        private int weight;
        private int quantity = 0;
        private int price;

        // constructor
        public MedicineWeight(int weight, int quantity, int price) 
        {
            this.weight = weight;
            Add_Quantity(quantity);
            Set_Price(price);
        }

        // functions
        // increments quantity
        public bool Add_Quantity(int Quantity) 
        {
            if (this.quantity + Quantity > 0 && Quantity > 0)
            {
                this.quantity += Quantity;
                return true;
            }
            return false;
        }

        public bool Sale_Quantity(int Quantity)
        {
            if (this.quantity - Quantity >= 0)
            {
                this.quantity -= Quantity;
                return true;
            }
            return false;
        }

        // changes price
        public bool Set_Price(int price)
        {
            if (price > 0)
            {
                this.price = price;
                return true;
            }
            return false;
        }


        // get set functions
        // returns quantity of medicine
        public int Get_Quantity() 
        {
            return this.quantity;
        }
        // returns weight of medicine
        public int Get_Weight()
        {
            return this.weight;
        }
        // returns price as int
        public int Get_Price()
        {
            return this.price;
        }

        // returns the state of variables
        public string ToString()
        {
            return $"Weight : {this.weight} Quantity : {this.quantity} Price : {this.price}";
        }

       

    }
}
