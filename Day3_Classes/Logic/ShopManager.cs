using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day3_Classes
{
    public class ShopManager
    {
        private Basket Basket { get; set; }
        private Storage Storage { get; set; }
        public ShopManager()
        {
            Basket = new Basket();
            Storage = new Storage();
        }
        /*// Class for the logic
         *  // In the constructor new basket and new storage are created
         *  class ShopManager
         *  + Basket Basket;
         *  + Storage Storage;
         *  // method returns all the items inside Storage, sorted by the name 
         *  - List<Item> GetAvailableItems()
         *  // method check if item by this name exists in the storage. 
         *  // If not - returns null, otherwise adds item to the basket and returns it as result.
         *  - Item AddToBasket(string name)
         *  
         *  // Returns total price of all items in the basket
         *  - decimal CheckOut()
         *  // Returns all items in the basket, sorted by the price 
         *  - List<Item> Pay()
         */
        // method returns all the items inside Storage, sorted by the name 
        public List<Item> GetAvailableItems()
        {

            return Storage.Items.OrderBy(Item => Item.Name).ToList();
            
        }
        public Item AddToBasket(string name)
        {
            Item item = Storage.Items.Find(i => i.Name.ToLower() == name.ToLower());

            if (item != null)
            {
                Basket.Items.Add(item);
            }
            return item;
        }
        public decimal CheckOut()
        {
            return Basket.CalculateTotalPrice();
        }

        public List<Item> Pay()
        {
            return Basket.Items.OrderBy(i => i.Price).ToList();
        }
    }
}
