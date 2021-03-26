using System;
using System.Collections.Generic;
using System.Text;

namespace Bicycle_Rental.Data
{
    public class Inventory
    {
       public List<Bicycle> Bikes { get; set; }

        public Inventory()
        {
            Bikes = new List<Bicycle>();
            Bikes.Add(new Bicycle(01, "Norco Search XR A1", 7.00));
            Bikes.Add(new Bicycle(02, "Trek Emonda SLR 9", 5.99));
            Bikes.Add(new Bicycle(03, "Trek Rail 9.9", 4.99));
            Bikes.Add(new Bicycle(04, "Norco Sight C1", 7.00));
            Bikes.Add(new Bicycle(05, "Giant ATX", 3.99));
            Bikes.Add(new Bicycle(06, "GT Grade Elite", 5.99));
        }
    }
}
