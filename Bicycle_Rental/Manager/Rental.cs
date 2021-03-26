using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Bicycle_Rental.Data;

namespace Bicycle_Rental.Manager
{
   public class Rental
    {
        private Bicycle Bike { get; set; }   
        private Inventory ListOfBikes { get; set; }   
        private User Renter { get; set; }
        public Rental()
        {
            Bike = new Bicycle();
            Renter = new User();
            ListOfBikes = new Inventory();

        }

        public List<Bicycle> AvailableBikes()
        {
            return ListOfBikes.Bikes.OrderBy(b => b.Model).ToList();
        }

        public Bicycle AddToUser(int id)
        {
            Bicycle bike = ListOfBikes.Bikes.Find(b => b.IdNumber == id);
            if (bike != null)
            {
                Renter.Bikes.Add(bike);
            }
            return bike;
        }

        public User AddRenter(string email, int time)
        {
            User customer = new User
            {
                Email = email,
                RentTime = time
            };
            return customer;
        }

        public double CheckOut()
        {
            return Renter.TotalCost();
        }
       public List<Bicycle> CompleteTransaction()
        {
            return Renter.Bikes.OrderBy(b => b.Cost).ToList();
        }
    }
}
