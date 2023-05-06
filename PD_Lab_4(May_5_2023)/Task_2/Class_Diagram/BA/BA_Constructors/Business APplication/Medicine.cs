using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_APplication
{
    class Medicine
    {
        public string name;
        public string price;
        public string weight;

        public Medicine(string name) // Creates a medicine with only name attrbute given by user
        {

            this.name = name;
        }

        public Medicine(Medicine medicine) // Copy Donstructor
        {
            this.name = medicine.name;
            this.price = medicine.price;
            this.weight = medicine.weight;
        }

        public Medicine(string name, string price, string weight) // Creates a medicine object with all of the attributes given by user
        {
            this.name = name;
            this.price = price;
            this.weight = weight;
        }

        public List<Medicine> Add_Medicine(List<Medicine> medicines) // Adds medicine to the list given as parameter and after adding returns the same list
        {
            Medicine newmedicine = new Medicine(this.name, this.price, this.weight);
            medicines.Add(newmedicine);
            return medicines;
        }

        public void Update_Medicine_Price(string price) // updates price of the medicine
        {
            this.price = price;
        }

        public List<Medicine> Remove_Medicine(List<Medicine> medicines) // removes the medicine form the list given as parameter and then returns the same list
        {
            int index = Get_Medicine_index(medicines);
            medicines.RemoveAt(index);
            return medicines;
        }


        public int Get_Medicine_index(List<Medicine> medicines) // returns the index where the object is stored in list
        {
            for (int idx = 0; idx < medicines.Count; idx++)
            {
                if (medicines[idx].Is_Medicine_Present(this.name))
                {
                    return idx;
                }
            }
            return -1;
        }

        public bool Is_Medicine_Present(List<Medicine> medicines) // returns true if 
        {
            bool is_present = false;
            foreach (Medicine medicine in medicines)
            {
                if (medicine.name == this.name)
                {
                    is_present = true;
                }
            }
            return is_present;
        }

        public bool Validate_quantity(string quantity)
        {
            bool Is_valid = true;
            if (quantity[0] == '0')
            {
                Is_valid = false;
            }
            for (int character = 0; character < quantity.Length; character++)
            {
                int c = quantity[character];
                if (c < 48 || c > 58)
                {
                    Is_valid = false;
                    break;
                }
            }
            return Is_valid;
        }

        public bool Validate_Name()
        {
            bool Is_valid = true;
            for (int idx = 0; idx < (this.name).Length; idx++)
            {
                int c = (int)(this.name)[idx];
                if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
                {
                    continue;
                }
                else
                {
                    Is_valid = false;
                    break;
                }
            }
            return Is_valid;
        }

        public bool Is_Medicine_Present(string medicine_name)
        {
            bool is_Present = false;
            if (this.name == medicine_name)
            {
                is_Present = true;
            }
            return is_Present;
        }
    }
}
