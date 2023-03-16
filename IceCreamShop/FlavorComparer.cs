﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamShop
{
    public class FlavorComparer : IComparer<Flavor>
    {

        //public int Compare(Flavor x, Flavor y)
        //{
        //    //return string.Compare(x.Name, y.Name);
        //}
        public int Compare(Flavor x, Flavor y)
        { 
        
        
            double allergenDiff = x.Allergens.Count - y.Allergens.Count;
            if (allergenDiff > 0)
            {
                return 1;  
            }
            else if (allergenDiff < 0) 
            { 
                return -1; 
            } 
            else 
            { 
                return 0; 
            }
        }
    }
}
