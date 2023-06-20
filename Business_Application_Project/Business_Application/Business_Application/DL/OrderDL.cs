using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.DL
{
    /// <summary>
    /// Contains Order related functions
    /// </summary>
    public class OrderDL
    { 
        public static string Previous_Orders_File = @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Business_Application_Project\Business_Application\Business_Application\Files\Previous_Orders.txt";

        // saves order in orders list
        public static void Save_Order(Order order)
        {
            StreamWriter FileVar = new StreamWriter(Previous_Orders_File);
            FileVar.WriteLine(Get_Order_String(order));
            FileVar.Flush();
            FileVar.Close();
        }

        // Creates Order Data string to save on file
        static string Get_Order_String(Order order)
        {
            string line = "";
            line += "Date-Time : " + order.Get_DateTime() + " ";
            Medicine medicine;
            if (order.medicines.Count > 1)
            {
                for (int i = 0; i < order.medicines.Count - 1; i++)
                {
                    medicine = order.medicines[i];
                    line += "Medicine Name : " + medicine.Get_Medicine_Name() + "  Weight : " + medicine.Get_Medicine_Weights()[0].Get_Weight() + "Quantity : " + medicine.Get_Medicine_Weights()[0].Get_Quantity() + " Price : " + medicine.Get_Medicine_Weights()[0].Get_Price();
                    line += "@";
                }
                medicine = order.medicines[order.medicines.Count - 1];
                line += medicine.Get_Medicine_Name() + ";" + medicine.Get_Medicine_Weights()[0].Get_Weight() + ";" + medicine.Get_Medicine_Weights()[0].Get_Quantity() + ";" + medicine.Get_Medicine_Weights()[0].Get_Price();
            }
            else if (order.medicines.Count == 1)
            {
                medicine = order.medicines[0];
                line += "Medicine Name : " + medicine.Get_Medicine_Name() + "  Weight : " + medicine.Get_Medicine_Weights()[0].Get_Weight() + "Quantity : " + medicine.Get_Medicine_Weights()[0].Get_Quantity() + " Price : " + medicine.Get_Medicine_Weights()[0].Get_Price();
            }
            return line;
        }



    }
}
