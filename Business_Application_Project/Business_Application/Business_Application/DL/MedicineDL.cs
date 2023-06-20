using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application
{
    /// <summary>
    /// contains all medicine data and CRUD Functionality
    /// </summary>
    
    public class MedicineDL
    {
        private static string medicine_data_file = @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Business_Application_Project\Business_Application\Business_Application\Files\Medicines_Data.txt";
        // list that contains all medicines
        public static List<Medicine> medicines = new List<Medicine>();

        // add medicine to list
        public static bool Add_Medicine(Medicine medicine)
        {
            // checks condition if specified medicine isn't null and
            // medicines list already doesn't contains that medicine object
            if (medicine != null && !(medicines.Contains(medicine))) 
            {
                medicines.Add(medicine);
                return true;
            }
            return false;
        }

        //to remove whole medicine
        public static bool Remove_Medicine(Medicine medicine) 
        {

            // removes the indicating medicine
            if(medicines.Remove(medicine))
            {
                // returns true if medicine is removed
                return true;
            }
            // returns false if medicine is not removed
            return false;

        }

        // reads medicine data from list
        public static bool Read_Medicine_Data()
        {
            StreamReader FileVar = new StreamReader(medicine_data_file);
            if (File.Exists(medicine_data_file))
            {
                string line = "";
                while ((line = FileVar.ReadLine()) != null)
                {
                    string[] Medicine_Data = line.Split(',');
                    // first word is Medicine Name
                    string Medicine_Name = Medicine_Data[0];
                    // validating medicine name
                    if (ValidationUI.Is_String_Valid(Medicine_Name)== false) 
                    {
                        continue;
                    }

                    // creating a new medicine with name
                    Medicine newmedicine = new Medicine(Medicine_Name);
                    bool Add_Medicine = true; // flag to check should medicine be added
                    // splitting medicine weights
                    string[] Medicine_Instances_List = Medicine_Data[1].Split('@');
                    // looping through each weight
                    foreach(string medicine_attributes in Medicine_Instances_List)
                    {
                        // splitting weight attributes
                        string[] medicine_attributes_list = medicine_attributes.Split(';');
                        string weight = medicine_attributes_list[0];
                        if (ValidationUI.Validate_Int_String(weight) == false) // validating weight
                        {
                            Add_Medicine = false;
                            continue;
                        }
                        string quantity = medicine_attributes_list[1];
                        if (ValidationUI.Validate_Int_String(quantity) == false) // validating quantity
                        {
                            Add_Medicine = false;
                            continue;
                        }
                        string price = medicine_attributes_list[2];
                        if (ValidationUI.Validate_Int_String(price) == false)  // validating price
                        {
                            Add_Medicine = false;
                            continue;
                        }
                        // creating a new medicine
                        MedicineWeight newweight = new MedicineWeight(int.Parse(weight), int.Parse(quantity), int.Parse(price));
                        // adding medicine weight to medicine.
                        newmedicine.Add_MedicineInstance(newweight);
                    }
                    if (Add_Medicine)
                    {
                        MedicineDL.Add_Medicine(newmedicine);
                    }
                }
                FileVar.Close();
                return true;
            }
            return false;
        }

        // save all medicines data on file
        public static void Save_All_Medicines()
        {
            if (File.Exists(medicine_data_file)) 
            {
                // initializing filevariable that overrides data on file
                StreamWriter FileVar = new StreamWriter(medicine_data_file, false); 
                // Selects each medicine stores in medicines list
                foreach(Medicine medicine in MedicineDL.medicines)
                {
                    // writes each medicine data on file.
                    FileVar.WriteLine(Get_Medicine_Data(medicine));
                }
                FileVar.Flush();
                FileVar.Close();
            }
        }

        // Save Medicine Data onto the File
        public static void Save_Single_Medicine(Medicine medicine)
        {
            if (File.Exists(medicine_data_file))
            {
                string line = Get_Medicine_Data(medicine);
                StreamWriter FileVar = new StreamWriter(medicine_data_file, true); // appends the file
                FileVar.WriteLine(line);
                FileVar.Flush();
                FileVar.Close();
            }
        }

        // returns medicine data as string to save on file
        private static string Get_Medicine_Data(Medicine medicine)
        {
            string line = "";
            // adding medicine weight to line
            line += medicine.Get_Medicine_Name() + ",";
            // creating list of specified medicine weight
            List<MedicineWeight> medicine_weights = medicine.Get_Medicine_Weights();
            MedicineWeight medicine_weight;
            // adds medicine weights data to string
            for (int weight_no = 0; weight_no < medicine_weights.Count - 1; weight_no++)
            {
                medicine_weight = medicine_weights[weight_no];
                line += medicine_weight.Get_Weight() + ";" + medicine_weight.Get_Quantity() + ";" + medicine_weight.Get_Price();
                line += "@";
            }
            // adds last medicine weight data to string
            medicine_weight = medicine_weights[medicine_weights.Count - 1];
            line += medicine_weight.Get_Weight() + ";" + medicine_weight.Get_Quantity() + ";" + medicine_weight.Get_Price();
            // returns the string having all data of medicine
            return line;
        }

        // get medicine from list by medicine name
        public static Medicine Get_Medicine(string medicine_name)
        {
            foreach(Medicine medicine in medicines)
            {
                // if any medicines name attributes matches specified string name
                if (medicine.Get_Medicine_Name() == medicine_name)
                {
                    // returns that medicine instance
                    return medicine;
                }
            }
            // returns null if no medicine is present with specified medicine name attributes
            return null; 
        }

        // Removes Sold Quantities
        public static void Sale_Medicines(Order order)
        {
            foreach(Medicine orderedmedicine in order.medicines) // selects medicine from order list
            {
                foreach(Medicine stockmedicine in medicines) // selects each medicine from stock medicines
                {
                    if (stockmedicine.Get_Medicine_Name() == orderedmedicine.Get_Medicine_Name()) // selects ordred medicine from stock medicine
                    { 
                        foreach(MedicineWeight stockmedicineweight in stockmedicine.Get_Medicine_Weights()) // selects the weight of ordered medicine
                        {
                            if (stockmedicineweight.Get_Weight() == orderedmedicine.Get_Medicine_Weights()[0].Get_Weight()) // selects weight that matches with ordred medicines weight
                            {
                                stockmedicineweight.Sale_Quantity(orderedmedicine.Get_Medicine_Weights()[0].Get_Quantity()); // removes quantity from stock medicine
                                stockmedicine.Remove_EmptyMedicine_Weight(); // removes medicine weight of which quantities are zero
                            }
                        }
                    }
                }
            }
        }


    }
}
