using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day3_Classes
{
    public class Basket
    {
        //Class for users's basket
        public List<Item> Items { get; set; }
        
         
        // In the constructor empty list is created
        public Basket()
        {
            Items = new List<Item>();
        }
        
        
        public decimal CalculateTotalPrice()
        {
            //decimal totalPrice = 0;
            //foreach (var item in Items)
            //{
            //    totalPrice += item.Price;
            //}
            //return totalPrice;

            //or use LINQ
            return Items.Sum(i => i.Price);

        }
    }
}
