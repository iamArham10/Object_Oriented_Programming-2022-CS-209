using Pharmacy_Management_System.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.DL
{
    public abstract class MedicineDL
    {
        private static readonly string medicine_data_file = @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Business_Application_Project\Business_Application\Business_Application\Files\Medicines_Data.txt";
        // list that contains all medicines
        public static List<Medicine> medicines = new();

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
            if (medicines.Remove(medicine))
            {
                // returns true if medicine is removed
                return true;
            }
            // returns false if medicine is not removed
            return false;

        }

        // returns the list of medicines with the same name given in parameter
        public static List<Medicine> Get_Req_Medicine_List(string name)
        {
            List<Medicine> reqMedicines = new();
            foreach (var medicine in medicines)
            {
                if (medicine.Name == name)
                {
                    reqMedicines.Add(medicine);
                }
            }
            return reqMedicines;
        }

        // reads medicine data from list
        public static bool Load_Medicine_Data()
        {
            StreamReader FileVar = new StreamReader(medicine_data_file);
            if (File.Exists(medicine_data_file))
            {
                string line;
                while ((line = FileVar.ReadLine()) != null)
                {
                    Medicine loadedmedicine = Read_Medicine(line);
                    if (loadedmedicine != null)
                    {
                        MedicineDL.Add_Medicine(loadedmedicine);
                    }
                }
                FileVar.Close();
                return true;
            }
            return false;
        }

        public static bool Check_Medicine_Object(Medicine medicine)
        {
            foreach (Medicine _medicine in medicines)
            {
                if (medicine.Name == _medicine.Name)
                {
                    if (medicine.Weight == _medicine.Weight)
                    {
                        if (medicine.Price == _medicine.Price)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // save all medicines data on file
        public static void Save_All_Medicines()
        {
            if (File.Exists(medicine_data_file))
            {
                // initializing filevariable that overrides data on file
                StreamWriter FileVar = new(medicine_data_file, false);
                // Selects each medicine stores in medicines list
                foreach (Medicine medicine in MedicineDL.medicines)
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
                StreamWriter FileVar = new(medicine_data_file, true); // appends the file
                FileVar.WriteLine(line);
                FileVar.Flush();
                FileVar.Close();
            }
        }

        // returns medicine data as string to save on file
        private static string Get_Medicine_Data(Medicine medicine)
        {
            return $"{medicine.Get_Medicine_Name()},{medicine.Weight},{medicine.Price},{medicine.Quantities}";
        }

        private static Medicine? Read_Medicine(string line)
        {
            if (string.IsNullOrEmpty(line)) return null;
            string[] data = line.Split(',');
            if (data[0] != null && data[1] != null && data[2] != null && data[3] != null)
            {
                Medicine medicine = new Medicine(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]));
                return medicine;
            }
            return null;

        }

        // get medicine from list by medicine name
        public static Medicine Get_Medicine(string medicine_name)
        {
            foreach (Medicine medicine in medicines)
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

        // to take order
        public static bool Take_Order(Order order)
        { 
            foreach(Medicine ordProducts in order.Products)
            {
                foreach(Medicine storedmedicine in medicines)
                {
                    if (ordProducts.Name == storedmedicine.Name && ordProducts.Weight == storedmedicine.Weight)
                    {
                        if (storedmedicine.Add_Quantities(ordProducts.Quantities * -1))
                        {
                            ordProducts.Quantities = 0;
                        }   
                    }
                }
            }
            order.Clear_Order();
            Clear_UnavailableProducts();
            Save_All_Medicines();
            return true;
        }

        private static void Clear_UnavailableProducts()
        {
            List<Medicine> list = new List<Medicine>();
            foreach(Medicine storedm in medicines)
            {
                if (storedm.Quantities == 0)
                {
                    list.Add(storedm);
                }
            }
            foreach(Medicine m in list)
            {
                medicines.Remove(m);
            }
        }
        
    }
}
