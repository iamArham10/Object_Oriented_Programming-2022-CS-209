using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_1
{
    class MenuItemUI
    {
        public static MenuItem Get_Menu_Item()
        {
            Console.WriteLine("Enter Item Name: ");
            string Itemname = Console.ReadLine();
            Console.WriteLine("Enter Item Type");
            string Itemtype = Console.ReadLine();
            Console.WriteLine("Enter Price of the Item: ");
            int Itemprice = int.Parse(Console.ReadLine());
            MenuItem newmenuitem = new MenuItem(Itemname, Itemtype, Itemprice);
            if (MenuItemDL.Return_Item(Itemname) == null)
            {
                return newmenuitem;
            }
            else
            {
                return null;
            }
            
        }

        public static void Print_Item(MenuItem item)
        {
            Console.WriteLine($"Item Name : {item.name}");
            Console.WriteLine($"Item Type : {item.type}");
            Console.WriteLine($"Item Price : {item.price}");
        }

        public static void Print_Items(List<MenuItem> items)
        {
            int itemno = 0;
            foreach(MenuItem item in items)
            {
                Console.WriteLine("Item No : {0}",itemno);
                Print_Item(item);
                Console.WriteLine("\n");
                itemno++;
            }
        }
    }
}
