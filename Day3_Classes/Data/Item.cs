using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_Classes
{
    public class Item
    {
        public string Name { get; set; }
       
        public decimal Price { get; set; }

        public Item(string name, int price)
        {
            Name = name;
            Price = price;
        }
       
        public Item()
        {

        }

    }
}
