using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application
{
    // stores order Date and time and products
    public class Order
    {
        // attribute

        private DateTime Date; // stores the date and time the order was created
        public List<Medicine> medicines = new List<Medicine>();
        
        // contructor 
        public Order(List<Medicine> medicines)
        {
            Date = DateTime.Now; // .Now is a static function that returns current date of local computer
            this.medicines = medicines;
        }

        // returns Total Amount
        public int Total()
        {
            int total = 0;
            foreach(Medicine medicine in medicines)
            {
                total += medicine.Get_Medicine_Weights()[0].Get_Quantity() * medicine.Get_Medicine_Weights()[0].Get_Price();
            }
            return total;
        }    
        
        public string Get_DateTime()
        {
            return Date.ToString();
        }
    }
}
