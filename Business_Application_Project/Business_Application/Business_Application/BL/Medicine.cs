using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application
{
    public class Medicine
    /// <summary>
    /// Medicine class is a blueprint of medicine object
    /// Medicine has different weights
    /// </summary>
    {
        // attributes
        private string name;
        // medicine has different weights and it's quantities
        // list contains all medicineweights objects
        List<MedicineWeight> weights = new List<MedicineWeight>();

        // constructor
        public Medicine(string name)
        {
            this.name = name;
        }

        // functions

        // returns the medicine name as string
        public string Get_Medicine_Name()
        {
            return this.name;
        }

        // add medicine weight and it's quantity to medicine object
        public void Add_MedicineInstance(MedicineWeight weight)
        {
            weights.Add(weight);
        }

        // removes medicineweight by index
        public void Remove_MedicineInstance(int weightno)
        {
            if (weights.Count > 0 && (weightno > 0 && weightno <= weights.Count) ) 
            {
                weights.RemoveAt(weightno - 1);
            }
        }

        // returns medicine of weight
        public MedicineWeight Get_Medicine_Weight(int weight) 
        {
            foreach(MedicineWeight medicineweight in weights)
            {
                if (medicineweight.Get_Weight() == weight)
                {
                    return medicineweight;
                }
            }
            return null;
        }

        // changes medicine price of specific weight
        public bool Change_Medicine_Price(int weight, int price)
        {
            MedicineWeight medicineweight = Get_Medicine_Weight(weight);
            if(medicineweight.Set_Price(price))
            {
                return true;
            }
            return false;
        }

        // removes specified medicine weight.
        public bool Remove_Medicine_Weight(int weight_)
        {
            foreach(MedicineWeight weight in weights)
            {
                if (weight.Get_Weight() == weight_)
                {
                    weights.Remove(weight);
                    return true;
                }
            }
            return false;
        }
        
        // returns list of medicine weights
        public List<MedicineWeight> Get_Medicine_Weights()
        {
            return weights;
        }

        // returns the state of variables
        public override string ToString()
        {
            string state = $"{this.name} : ";
            foreach(MedicineWeight weight in weights)
            {
                state += weight.ToString();
                state += ",";
            }
            return state;
        }

        // removes medicine of quantity o
        public void Remove_EmptyMedicine_Weight()
        {
            foreach (MedicineWeight mw in weights)
            {
                if (mw.Get_Quantity() == 0)
                {
                    Remove_Medicine_Weight(mw.Get_Weight());
                }
            }
        }

    }
}
