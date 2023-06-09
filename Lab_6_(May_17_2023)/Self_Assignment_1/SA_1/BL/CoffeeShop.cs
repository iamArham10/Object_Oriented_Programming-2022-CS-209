using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_1
{
    class CoffeeShop
    {
        // attributes
        public string name;
        public List<MenuItem> items = new List<MenuItem>();
        public List<string> Orders = new List<string>();

        // constructors
        public CoffeeShop(string Name)
        {
            this.name = Name;
        }
        // methods

        //1:
        public bool Add_Menu_Item(MenuItem item) // adds Object MenuItem To list items
        {
            if (item != null)
            {
                items.Add(item);
                return true;
            }
            return false;
        }

        //2:
        public bool Add_Order(string OrderName) // adds string ordername in orders list
        {
            foreach (MenuItem item in items)
            {
                if (OrderName == item.name) // if MenuItem contains object with name attribute matching String ordername
                {
                    Orders.Add(OrderName); // adds string ordername to order
                    return true;
                }
            }
            return false;
        }

        //3:
        public string Fulfill_Order()
        {
            if (Orders.Count > 0)
            {
                string Order = Orders[0];
                Orders.RemoveAt(0);
                return Order;
            }
            else
            {
                return "Null";
            }
        }

        //3:
        public List<string> List_Orders()
        {
            return Orders; // returns the list of Orders Added to the Object
        }

        //4:
        public int Due_Amount()
        {
            int Price = 0;
            foreach (string itemname in Orders) // assignes every item string name in Orders string list to itemname var
            {
                foreach (MenuItem item in items) // assigns every MenuItem item from items to item var
                {
                    if (itemname == item.name) // checks if MenuItem object attribute name equals to string itemname
                    {
                        Price += item.price;  // calculate total price of all of the Menu items added
                    }
                }
            }

            return Price;
        }

        //5:
        public MenuItem Cheapest_Item()
        {
            items = items.OrderByDescending(o => o.price).ToList(); // shorts the list in decending order.
            return items[(items.Count) - 1];                   // returns the last element of list having lowers price.
        }

        //6:
        public void Drinks_Only(List<MenuItem> drinkitems) // returns the MenuItem Object 
        {

            foreach (MenuItem item in items)
            {
                if (item.type == "Drink")           // whose type string is assigned to Drink
                {
                    drinkitems.Add(item);
                }
            }
        }

        //7:
        public void Food_Only(List<MenuItem> foods)
        {
            foreach (MenuItem item in items)
            {
                if (item.type == "Food")           // whose type string is assigned to Drink
                {
                    foods.Add(item);
                }
            }
        }
    }
}
