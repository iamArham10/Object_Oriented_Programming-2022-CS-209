using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application
{
    
    public class MedicineUI
    {
        /// <summary>
        /// MedicineUI class has functions that will input and output medicine data to console
        /// </summary>
        
        // functions
        // this function creates inputs medicine data and creates a Medicine
        public static Medicine Create_Medicine(int X_Cord, int Y_Cord)
        {
            // takes medicine name from user
            Console.SetCursorPosition(X_Cord, Y_Cord);
            string message = "Enter Medicine Name : ";
            Console.Write(message);
            string Name = MainUI.Get_String_Input(message,X_Cord, Y_Cord);
            // validates if medicine already exists in medicines
            Medicine medicine = MedicineDL.Get_Medicine(Name);
            // if medicine is not null meaning medicine already exists with that name
            if (medicine != null)
            {
                // return null
                return null;
            }

            // else creates a new medicine
            medicine = new Medicine(Name);
            // inputs number of medicine weights
            Y_Cord++;
            Console.SetCursorPosition(X_Cord, Y_Cord);
            message = "Number of Weights To Add : ";
            Console.Write(message);
            Console.SetCursorPosition(X_Cord + message.Length, Y_Cord);
            string nofmedicines = Console.ReadLine();
            if (nofmedicines == null)
            {
                return null;
            }

            Y_Cord++;
            // validates integer
            while (ValidationUI.Validate_Int_String(nofmedicines) == false)
            {
                nofmedicines = MainUI.Take_Integer_Input(message , X_Cord , Y_Cord);
            }

            // converts it into integer
            int NofMedicines = int.Parse(nofmedicines);
            // noofMedicines times takes medicinweight input 
            for(int i = 0; i <  NofMedicines; i++) 
            {
                Console.SetCursorPosition(X_Cord - 30 , Y_Cord);
                Console.Write($"Weight Number {i+1} : ");
                MedicineWeight medicineWeight= Create_Medicine_Weight(X_Cord, Y_Cord);
                Y_Cord = Y_Cord + 3;
                medicine.Add_MedicineInstance(medicineWeight);
            }
            // returns medicine
            return medicine;
        }

        // inputs medicine weight data from user and returns it
        public static MedicineWeight Create_Medicine_Weight(int Cord_x, int Cord_y)
        {
            // inputs weight from user
            Console.SetCursorPosition(Cord_x, Cord_y);
            string message = "Enter Weight(mg) : ";
            Console.Write(message);
            string weight = MainUI.Take_Integer_Input(message, Cord_x, Cord_y); // takes medicine weight input from user

            // inputs quantity from user
            message = "Enter Quantity : ";
            Cord_y++;
            Console.SetCursorPosition(Cord_x, Cord_y);
            Console.Write(message);
            string quantity = MainUI.Take_Integer_Input(message, Cord_x, Cord_y); // takes medicine quantity input from user

            // inputs price 
            message = "Enter Price : ";
            Cord_y++;
            Console.SetCursorPosition(Cord_x, Cord_y);
            Console.Write(message);
            string price = MainUI.Take_Integer_Input(message , Cord_x , Cord_y); // takes medicine price input from user

            // converts all strings to integers
            int intweight = int.Parse(weight);
            int intquantity = int.Parse(weight);
            int intprice = int.Parse(price);

            // inititates medicine weight object
            MedicineWeight MW = new MedicineWeight(intweight, intquantity, intprice);
            // returns it 
            return MW;
        }

        // Add Medicine Stock Function
        public static bool Add_Medicine_Stock(int cord_x, int cord_y)
        {
            // gets medicine name from user
            string message = "Enter Medicine Name : ";
            Console.SetCursorPosition(cord_x, cord_y);
            string Medicine_Name = MainUI.Get_String_Input(message, cord_x, cord_y);
            // gets medicine from medicine lists
            Medicine Required_Medicine = MedicineDL.Get_Medicine(Medicine_Name);
            cord_y++;
            if (Required_Medicine != null) // if medicine is present
            {
                // Prints All Medicine Data
                Print_Medicine_Data(cord_x, ref cord_y, Required_Medicine);
                cord_y++;
                // asks user to select medicine weight to change the price
                message = "Select Weight Number : ";
                Console.SetCursorPosition(cord_x, cord_y);
                Console.Write(message);
                string Weight_No = "-1";
                while (int.Parse(Weight_No) > Required_Medicine.Get_Medicine_Weights().Count || int.Parse(Weight_No) < 1)
                {
                    Weight_No = MainUI.Take_Integer_Input(message, cord_x, cord_y);
                }
                // selects user asked medicine weight of user
                MedicineWeight selected_medicine_weight = Required_Medicine.Get_Medicine_Weights()[int.Parse(Weight_No)];
                cord_y++;
                // asks user to enter new price
                message = "Enter Quantities To Add : ";
                Console.SetCursorPosition(cord_x, cord_y);
                string Quantities = MainUI.Take_Integer_Input(message, cord_x, cord_y);
                cord_y++;
                Console.SetCursorPosition(cord_x, cord_y);
                if (selected_medicine_weight.Add_Quantity(int.Parse(Quantities)))
                {
                    Console.Write("Quantities Added Succesfully");
                    return true;
                }
                else
                {
                    Console.Write("Quantities are Not Added");
                    return false;
                }

            }
            else
            {
                Console.SetCursorPosition(cord_x, cord_y);
                Console.WriteLine("Medicine Is Not Present");
                return false;
            }


        }

        // view all medicines 
        public static void View_Medicines(int cord_x, int cord_y)
        {
            foreach(Medicine medicine in MedicineDL.medicines)
            {
                Console.SetCursorPosition(cord_x, cord_y);
                Console.Write("Name : " + medicine.Get_Medicine_Name());
                cord_y++;
                foreach(MedicineWeight medicineweight in medicine.Get_Medicine_Weights())
                {
                    Console.SetCursorPosition(cord_x, cord_y);
                    Console.Write("Weight : " + medicineweight.Get_Weight());
                    cord_y++;
                    Console.SetCursorPosition(cord_x, cord_y);
                    Console.Write("Quantity : " + medicineweight.Get_Price());
                    cord_y++;
                    Console.SetCursorPosition(cord_x , cord_y );
                    Console.Write("Price : " + medicineweight.Get_Price());
                }
                cord_y = cord_y + 2;
            }
        }

        // prints medicine data
        public static void Print_Medicine_Data(int cord_x,ref int cord_y, Medicine medicine)
        {
            cord_y++;
            int medicine_no = 1;
            foreach(MedicineWeight mw in medicine.Get_Medicine_Weights())
            {
                Console.SetCursorPosition(cord_x, cord_y);
                Console.WriteLine($"Weight No : {medicine_no} : {mw.ToString()}");
                cord_y = cord_y + 2;
                medicine_no++;
            }
        }
        
        // inputs medicine name from user and deletes it
        public static bool Remove_Medicine_Complete(int cord_x, int cord_y)
        {
            // takes medicine name from user
            string message = "Enter Medicine Name : ";
            Console.SetCursorPosition(cord_x, cord_y);
            Console.Write(message);
            string medicine_name = MainUI.Get_String_Input(message,cord_x, cord_y);
            // get's specified name medicine from medicines list
            Medicine Medicine_To_Remove = MedicineDL.Get_Medicine(medicine_name);
            // increases y coordinate of the game of 
            cord_y++;
            if (Medicine_To_Remove != null)
            {
                // prints all medicine data
                Print_Medicine_Data(cord_x,ref cord_y, Medicine_To_Remove);
                cord_y++; // incerements console vertical console position
                Console.SetCursorPosition(cord_x, cord_y);
                Console.Write("Enter Yes To Remove or anything else to not : ");
                // inputs decision from user
                string decision = Console.ReadLine();
                cord_y++;
                if (decision == "Yes")
                {
                    // removes medicine from medicines list
                    if (MedicineDL.Remove_Medicine(Medicine_To_Remove)) // if medicine is removed statement will be true
                    {
                        Console.SetCursorPosition(cord_x, cord_y);
                        Console.WriteLine("Medicine Deleted Succesfully");
                        cord_y++;
                        Console.SetCursorPosition(cord_x, cord_y);
                        Console.Write("Press Any Key To Exit");
                        return true;
                    }
                }
                else
                {
                    // if medicine is not removed 
                    Console.SetCursorPosition(cord_x, cord_y);
                    Console.Write("Medicine Not Deleted");
                    cord_y++;
                    Console.SetCursorPosition(cord_x, cord_y);
                    Console.Write("Press Any key to Exit");
                    return false;
                }
            }
            else
            {
                Console.SetCursorPosition(cord_x, cord_y);
                Console.Write("Medicine Is Not Present");
                return false;
            }
            return false;
            
        }   

        // add medicine weight
        public static bool Add_Medicine_Weight(int cord_x, int cord_y)
        {
            // gets medicine name from user
            string message = "Enter Medicine Name : ";
            Console.SetCursorPosition(cord_x, cord_y);
            Console.Write(message);
            string medicine_name = MainUI.Get_String_Input(message,cord_x, cord_y);
            cord_y++;
            // gets medicine from data layer 
            Medicine Requested_Medicine = MedicineDL.Get_Medicine(medicine_name);
            if (Requested_Medicine != null) // if medicine is present
            {
                // prints medicine data
                Print_Medicine_Data(cord_x, ref cord_y, Requested_Medicine);
                cord_y++;
                MedicineWeight medicineWeight = Create_Medicine_Weight(cord_x, cord_y);
                if (Requested_Medicine.Get_Medicine_Weights().Contains(medicineWeight) == false)
                {
                    Requested_Medicine.Add_MedicineInstance(medicineWeight);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;

        }
        
        // removes medicine weight
        public static bool Remove_Medicine_Weight(int cord_x, int cord_y)
        {
            // takes medicine name from user
            string message = "Enter Medicine Name : ";
            Console.SetCursorPosition(cord_x, cord_y);
            Console.Write(message);
            string medicine_name = MainUI.Get_String_Input(message, cord_x, cord_y);

            cord_y++;
            // gets requested medicine from medicines data stored
            Medicine Requ_Medicine = MedicineDL.Get_Medicine(medicine_name);
            if (Requ_Medicine != null)
            {
                Print_Medicine_Data(cord_x,ref cord_y, Requ_Medicine);
                cord_y++;
                Console.SetCursorPosition(cord_x, cord_y);
                message = "Enter Weight Number To Delete : ";
                Console.Write(message);
                string Weight_No = "-1";
                while (int.Parse(Weight_No) > Requ_Medicine.Get_Medicine_Weights().Count || int.Parse(Weight_No) < 1)
                {
                    Weight_No = MainUI.Take_Integer_Input(message, cord_x, cord_y);
                }
                cord_y++;
                Console.SetCursorPosition(cord_x, cord_y);
                message = "Enter Yes To Delete : ";
                Console.Write(message);
                Console.SetCursorPosition(cord_x + message.Length, cord_y);
                string Confirm = Console.ReadLine();
                if (Confirm == "Yes")
                {
                    Requ_Medicine.Remove_MedicineInstance(int.Parse(Weight_No));
                    cord_y++;
                    Console.SetCursorPosition(cord_x, cord_y);
                    Console.Write("Medicine Weight Removed Succesfully");
                    return true;
                }
                else 
                {
                    cord_y++;
                    Console.SetCursorPosition(cord_x, cord_y);
                    Console.Write("Medicine Weight Is Not Removed");
                    return false;
                }
            }
            else
            {
                Console.SetCursorPosition(cord_x, cord_y);
                Console.Write("Medicine Not Present");
                return false;
            }
        }

        // change medicine price
        public static bool Change_Medicine_Price(int cord_x, int cord_y)
        {
            bool isPriced_Changed = true;
            string message = "Enter Medicine Name : ";
            Console.SetCursorPosition(cord_x, cord_y);
            Console.Write(message);
            string medicine_name = MainUI.Get_String_Input(message, cord_x, cord_y);
            cord_y++;
            Medicine Requested_Medicine = MedicineDL.Get_Medicine(medicine_name);
            cord_y++;
            if (Requested_Medicine != null)
            { 
                Print_Medicine_Data(cord_x,ref cord_y, Requested_Medicine);
                message = "Enter Weight Number To Change Price : ";
                string Weight_No = Get_Weight_Number(Requested_Medicine, cord_x, cord_y);
                MedicineWeight requested_weight = Requested_Medicine.Get_Medicine_Weights()[int.Parse(Weight_No) - 1];
                cord_y++;
                message = "Enter New Price : ";
                Console.SetCursorPosition(cord_x, cord_y);
                Console.Write(message);
                string price = MainUI.Take_Integer_Input(message, cord_x, cord_y);
                if (requested_weight.Set_Price(int.Parse(price)))
                {
                    isPriced_Changed = true;
                }
            }
            return isPriced_Changed;
        }
        
        // gets weight number from user // takes weight , medicine and coordiantes ask user to enter valid weight of selected medicine
        public static string  Get_Weight_Number(Medicine medicine, int cord_x, int cord_y)
        {
            Console.SetCursorPosition(cord_x, cord_y);
            string message = "Select Weight Number : ";
            Console.Write(message);
            string Weight_No = "-1";
            while (int.Parse(Weight_No) > medicine.Get_Medicine_Weights().Count || int.Parse(Weight_No) < 1)
            {
                Weight_No = MainUI.Take_Integer_Input(message, cord_x, cord_y);
            }
            return Weight_No;
        }
    }
}
