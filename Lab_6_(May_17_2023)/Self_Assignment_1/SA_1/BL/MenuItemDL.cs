using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SA_1
{
    class MenuItemDL
    {
        public static List<MenuItem> items = new List<MenuItem>();

        public static void Add_Item(MenuItem item) // adds item to the list
        {
            if (item != null)
            {
                items.Add(item);
            }
        }

        public static void Save_Data_File(string path,MenuItem item) // saves data in file
        {
            StreamWriter FileVar = new StreamWriter(path, true);
            FileVar.WriteLine(item.name + "," + item.type + "," + item.price);
            FileVar.Flush();
            FileVar.Close();
        }

        public static bool Load_Menu_Items(string path)
        {
            StreamReader FileVar = new StreamReader(path);
            if (File.Exists(path))
            {
                string record;
                while ((record = FileVar.ReadLine()) != null)
                {
                    string[] separated_record = record.Split(',');
                    string itemname = separated_record[0];
                    string itemtype = separated_record[1];
                    int itemprice = int.Parse(separated_record[2]);
                    MenuItem item = new MenuItem(itemname, itemtype, itemprice);
                    Add_Item(item);
                }
                FileVar.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static MenuItem Return_Item(string itemname) // returns item whom name attribute is equal to given string as parameter
        {
            foreach(MenuItem item in items)
            {
                if (item.name == itemname)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
