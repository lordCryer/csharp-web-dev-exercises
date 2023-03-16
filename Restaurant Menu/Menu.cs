using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MenuLab
{
    public class Menu
    {
        public string RestaurantName { get; set; }
        public string Address { get; set; }
        public Dictionary<string, List<MenuItem>>ItemsByCatagory( get; set; )
            public DateTime LastRevised { get; set; }
        {
            Public Menu(string restaurantName, string address, Dictionary<string, List<MenuItem>> itemsByCategory, DateTime lastRevised) { 
            RestaurantName = restaurantName;
            Address = address;
            ItemsByCategory = itemsByCategory;
            LastRevised = lastRevised;
        }
        public void printOutMenuItem (string)
        }                                                                            
    }
}
