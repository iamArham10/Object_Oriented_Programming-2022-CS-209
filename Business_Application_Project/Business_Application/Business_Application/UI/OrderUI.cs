using Business_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business_Application
{
    // contains UI functions through which user can access order class
    public class OrderUI
    {
        // takes order
        public static Order Take_Order(int cord_x, int cord_y)
        {
            List<Medicine> medicines = new List<Medicine>();
            bool Taking_Order = true; // for loop to take medicine input
            bool isOrderTaken = false;
            Order newOrder = null;

            while(Taking_Order)
            {
                // take medicine name from user
                string message = "Enter Medicine Name : ";
                Console.SetCursorPosition(cord_x, cord_y);
                Console.Write(message);
                String Medicine_Name = MainUI.Get_String_Input(message, cord_x, cord_y);
                // gets medicine from user
                Medicine Requested_Medicine = MedicineDL.Get_Medicine(Medicine_Name);
                if (Requested_Medicine != null) // if medicine is present with entered name
                {
                    // prints medicine data
                    MedicineUI.Print_Medicine_Data(cord_x, ref cord_y, Requested_Medicine);
                    cord_y++;
                    Console.SetCursorPosition(cord_x, cord_y);
                    message = "Enter 'n' to exit or anything else to enter weight : ";
                    Console.Write(message);
                    string Weight_No = Console.ReadLine();
                    if (Weight_No == "n")
                    {
                        break;
                    }
                    cord_y++;
                    // takes valid weight number from user
                    if (ValidationUI.Validate_Int_String(Weight_No)) 
                    {
                        Weight_No = MedicineUI.Get_Weight_Number(Requested_Medicine, cord_x, cord_y);
                    }
                    else
                    {
                        break;
                    }
                    MedicineWeight selected_weight = Requested_Medicine.Get_Medicine_Weights()[int.Parse(Weight_No) - 1];
                    // taking quantities from user
                    message = "Enter Number of Quantities : ";
                    string Quantity = "\0";
                    bool taking_quantity = true;
                    while(taking_quantity)
                    {
                        Console.SetCursorPosition(cord_x, cord_y);
                        Console.WriteLine(message);
                        Quantity = MainUI.Take_Integer_Input(message, cord_x, cord_y);
                        if (int.Parse(Quantity) > selected_weight.Get_Quantity())
                        {
                            Console.SetCursorPosition(cord_x - 20, cord_y);
                            Console.Write("Quantity Not Available Press n to Exit or Anything else to Enter again");
                            char Take_Order_Again = Console.ReadKey(true).KeyChar;
                            if (Take_Order_Again == 'n')
                            {
                                Taking_Order = false;
                                taking_quantity = false;
                            }
                        }
                        else
                        {
                            taking_quantity = false;
                        }
                    }

                    if (Taking_Order == true)
                    {
                        // adds selected order of medicine to order List
                        string medicine_name = Requested_Medicine.Get_Medicine_Name();
                        Medicine Selected_Medicine = new Medicine(medicine_name); 
                        MedicineWeight Weight = new MedicineWeight(selected_weight.Get_Weight(), int.Parse(Quantity), selected_weight.Get_Price());
                        Selected_Medicine.Add_MedicineInstance(Weight);
                        medicines.Add(Selected_Medicine);
                        cord_y++;
                        Console.Write("Press y To Add Another Medicine");
                        cord_y++;
                        char Take_Order_Again = Console.ReadKey(true).KeyChar;
                        if (Take_Order_Again != 'y')
                        {
                            Taking_Order = false;
                        }
                        cord_y++;
                    }  
                }
            } // taking order while loop
            cord_y++;
            // creates a new order of medicines;
            if (medicines.Count > 0)
            {
                newOrder = new Order(medicines);
                Console.SetCursorPosition(cord_x, cord_y);
                Console.WriteLine("Your Total is " + newOrder.Total());
                cord_y++;
                Console.SetCursorPosition(cord_x, cord_y);
                Console.Write("Press y to confirm order or n to cancel");
                char confirm_order = Console.ReadKey(true).KeyChar;
                if (confirm_order == 'y')
                {
                    isOrderTaken = true;
                }
                cord_y++;
                Console.SetCursorPosition(cord_x, cord_y);
                Console.Write("Medicine Sold Succesfully");
                cord_y++;
                Console.Clear();    
            }
            return newOrder;
        }

        // prints the Order receipt
        public static void Print_Order_Receipt(Order order,int cord_x,int cord_y)
        {
            Console.SetCursorPosition(cord_x, cord_y); Console.WriteLine("----------------------------------------");
            cord_y++;
            Console.SetCursorPosition(cord_x, cord_y); Console.WriteLine("Description       Quantity         Price");
            cord_y++;
            foreach (Medicine medicine in order.medicines)
            {
                Console.SetCursorPosition(cord_x, cord_y); Console.Write(medicine.Get_Medicine_Name() + medicine.Get_Medicine_Weights()[0].Get_Weight() + "mg");
                Console.SetCursorPosition(cord_x + 18, cord_y); Console.Write(medicine.Get_Medicine_Weights()[0].Get_Quantity());
                Console.SetCursorPosition(cord_x + 35, cord_y); Console.Write(medicine.Get_Medicine_Weights()[0].Get_Price());
                cord_y++;
            }
            Console.SetCursorPosition(cord_x, cord_y); Console.WriteLine("Order Date " + order.Get_DateTime());
            cord_y++;
            Console.SetCursorPosition(cord_x, cord_y); Console.WriteLine("----------------------------------------");
            cord_y++;
            Console.SetCursorPosition(cord_y, cord_y); Console.WriteLine("Enter Any Key To Continue");
        }

        // prints previous order
        public static void Print_Previous_Orders(int cord_x, int cord_y)
        {
            MainUI.Print_File(OrderDL.Previous_Orders_File, cord_x, cord_y);
        }
    }
}
