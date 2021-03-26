using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Bicycle_Rental
{
    public class User
    {
        //for now each user will have an email without stipulation of symbols
        public string Email { get; set; }
        //each user chooses the time for how long they want to rent a bicycle
        public int RentTime { get; set; }

        public Bicycle RentalBike { get; set; }
        //if there is a number of bikes a user wants to rent
        public List<Bicycle> Bikes { get; set; }

        public User()
        {
            RentalBike = new Bicycle();
            Bikes = new List<Bicycle>();
        }
        public User(string email, int time)
        {
            Email = email;
            RentTime = time;
        }

        public double TotalCost(int id)
        {
            var bike = RentalBike.Bicycles.FirstOrDefault(b => b.IdNumber == id);
            var totalPrice = bike.Cost * RentTime;
            return totalPrice;
        }
        
    }
}
