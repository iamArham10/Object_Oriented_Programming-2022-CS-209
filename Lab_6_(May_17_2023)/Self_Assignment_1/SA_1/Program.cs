using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string itempath= @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Lab_6_(May_17_2023)\Self_Assignment_1\SA_1\Files\menuitems.txt";
            if(MenuItemDL.Load_Menu_Items(itempath))
            {
                Console.WriteLine("Menu Items Loaded Succesfully");
            }
            else
            {
                Console.WriteLine("No Menu Item Was Loaded");
            }
         

            CoffeeShop TeshaCS = new CoffeeShop("Tesha's Coffee Shop")
            {
                items = MenuItemDL.items
            };
            char option;
            do
            {
                MainMenuUI.Clear_Screen();
                option = MainMenuUI.MainMenu();
                if (option == '1')
                {
                    MenuItem menuitem = MenuItemUI.Get_Menu_Item();
                    if (menuitem != null)
                    {
                        TeshaCS.Add_Menu_Item(menuitem);
                        MenuItemDL.Save_Data_File(itempath, menuitem);
                    }
                }
                else if (option == '2')
                {
                    MenuItem CheapestItem = TeshaCS.Cheapest_Item();
                    MenuItemUI.Print_Item(CheapestItem);
                }
                else if (option == '3')
                {
                    List<MenuItem> Drinks = new List<MenuItem>();
                    TeshaCS.Drinks_Only(Drinks);
                    MenuItemUI.Print_Items(Drinks);
                }
                else if (option == '4')
                {
                    List<MenuItem> Foods = new List<MenuItem>();
                    TeshaCS.Food_Only(Foods);
                    MenuItemUI.Print_Items(Foods);
                }
                else if (option == '5')
                {
                    CoffeeShopUI.Take_Input(TeshaCS);
                }
                else if (option == '6')
                {
                    string Fulfilled_Order = TeshaCS.Fulfill_Order();
                    CoffeeShopUI.Print_Fulfilled_Order(Fulfilled_Order);
                }
                else if (option == 7)
                {
                    List<string> Order_List = TeshaCS.List_Orders();
                    CoffeeShopUI.Print_List_Orders(Order_List);
                }
                else if (option == '8')
                {
                    CoffeeShopUI.Print_Price(TeshaCS.Due_Amount());
                }
                MainMenuUI.End_Screen();
            } while (option != '9');
        }
    }
}
