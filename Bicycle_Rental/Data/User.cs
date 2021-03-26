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
        public string Email;
        //each user chooses the time for how long they want to rent a bicycle
        public int RentTime;
        
        public Bicycle RentalBike;
        //if there is a number of bikes a user wants to rent
        public List<Bicycle> Bikes { get; set; }

        public User()
        {
            RentalBike = new Bicycle();
            Bikes = new List<Bicycle>();
        }
        public User(string _email, int _time)
        {
            Email = _email;
            RentTime = _time;
        }

        public double TotalCost()
        {
            var totalPrice = Bikes.Sum(b => b.Cost * RentTime);
            return totalPrice;
        }
        
    }
}
