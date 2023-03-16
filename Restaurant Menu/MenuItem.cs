using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Menu

{
    
    
    {
        public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public bool IsNew { get; set; }
    public static DateTime PremierDate { get; set; } = DateTime.Now;

    public MenuItem(string name, string description, double price, bool isNew)
    {
        Name = name;
        Description = description;
        Price = price;
        IsNew = isNew;
    }





}
    
}
