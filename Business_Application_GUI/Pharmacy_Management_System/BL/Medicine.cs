using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.BL
{
    public class Medicine
    {
        // attributes
        private string name;
        private int weight;
        private int price;
        private int quantities;


        // constructor
        public Medicine(string name, int  weight, int price, int quantities)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
            this.quantities = quantities;
        }

        // functions

        // returns the medicine name as string
        public string Get_Medicine_Name()
        {
            return this.name;
        }

        public String Name
        {
            get { return this.name; }
        }

        public int Weight
        {
            get { return this.weight; }
            set
            {
                if (this.weight != value && value > 0)
                {

                    this.weight = value;
                }
            }
        }

        public int Quantities
        {
            get { return this.quantities; }
            set
            {
                if (this.quantities != value && value > 0)
                {

                    this.quantities = value;
                }
            }
        }

        public int Price
        {
            get { return this.price; }
            set
            {
                if (this.price != value && value > 0)
                {

                    this.price = value;
                }
            }
        }

        public bool Add_Quantities(int quantities)
        {
            if ((this.quantities + quantities) >= 0)
            {
                this.quantities += quantities;
                return true;
            }
            return false;
        }

        public Order contains
        {
            get => default;
            set
            {
            }
        }
    }
}
