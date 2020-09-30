using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe
{
    public class MenuContent
    {
        public string Number { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Ingredients { get; set; }
        public double Price { get; set; }
        public MenuContent() { }

        public MenuContent(string number, string name, string description, string ingredients, double price)
        {
            Number = number;
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }


        

    }
}
