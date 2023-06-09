using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Department
{
    class Hosepipe
    {
        /// <summary>
        /// hospipe class implements real life hosepipe
        /// contains material type, shape , diameter and flowrate attribute
        /// </summary>

        // attributes
        private string material;
        private string shape;
        private float diameter;
        private float flowrate;

        // constructor
        public Hosepipe(string material, string gshape, float diameter, float flowrate)
        {
            if (Is_Material_Valid(material))
            {
                this.material = material;
            }
            if (Is_Shape_Valid(gshape))
            {
                this.shape = gshape;
            }
            this.diameter = diameter;
            this.flowrate = flowrate;
        }

        // methods
        private bool Is_Material_Valid(string material) // checks material string is valid
        {
            bool isMaterialvalid = false; // flag tell if material attribute is assigned or not
            // condition checks if string given in parameter either of these two then will
            // return true;
            if (material == "Synthetic Rubber" || material == "Soft Plastic") 
            {
                isMaterialvalid = true;
            }
            return isMaterialvalid;
        }

        private bool Is_Shape_Valid(string shape) // checks shape string is valid argument
        {
            bool isShapevalid = false;
            if (shape == "Cylindrical" || shape == "Circular")
            {
                isShapevalid = true;
            }
            return isShapevalid;
        }

        // Get Functions
        public string Get_Material() 
        {
            return this.material;
        }

        public string Get_Shape() 
        {
            return this.shape;
        }
        
        public float Get_Diameter()
        {
            return this.diameter;
        }

        public float Get_FlowRate()
        {
            return this.flowrate;
        }
    }

}
