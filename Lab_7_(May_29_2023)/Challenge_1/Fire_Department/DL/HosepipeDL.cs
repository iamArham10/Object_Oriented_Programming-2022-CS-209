using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Department
{
    class HosepipeDL
    {
        /// <summary>
        /// Class contains all hosepipes objects data and functions related to them
        /// </summary>

        // attributes
        static public List<Hosepipe> hosepipes = new List<Hosepipe>();

        // related functions

        // add hosepipe object to hosepipes list
        static public bool Add_Hosepipe(Hosepipe hosepipe)
        {
            bool isHosepipeAdded = false;
            if (!(hosepipes.Contains(hosepipe)))
            {
                hosepipes.Add(hosepipe);
                isHosepipeAdded = true;
            }
            return isHosepipeAdded;
        }

        static public Hosepipe Get_HosePipe(Hosepipe ReqHosepipe) // returns the hosepipe of all given hosepipe matches required one
        {
            foreach(Hosepipe hosepipe in hosepipes)
            {
                if (hosepipe.Get_Shape() == ReqHosepipe.Get_Shape())
                {
                    if (hosepipe.Get_Material() == ReqHosepipe.Get_Material())
                    {
                        if (hosepipe.Get_Diameter() == ReqHosepipe.Get_Diameter())
                        {
                            if (hosepipe.Get_FlowRate() == ReqHosepipe.Get_FlowRate())
                            {
                                return hosepipe;
                            }
                        }
                    }
                }
            }
            return null;
        }
    }
}
