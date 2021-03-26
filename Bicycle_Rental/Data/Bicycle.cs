using System;
using System.Collections.Generic;
using System.Linq;

namespace Bicycle_Rental
{
    public class Bicycle
    {
        /*
         * Requirements:
                ● Information about bicycles (name and number) is stored in a list (predefined
                list);
                ● Reservations (user email, rental period, selected bicycle) are stored in a list;
                ● To rent a bicycle user specifies bike’s number, rental period and e-mail;
                ● Check if the entered bike’s number exists in a list;
                ● Multiple reservations can be done (after the reservation ask if user would like
                to make another reservation e.g. for another user, using different email)
                ● Object-oriented approach (creating multiple classes to separate logic)

         */
        public int IdNumber { get; set; }
        public string Model { get; set; }
        public double Cost { get; set; }

        public List<Bicycle> Bicycles = new List<Bicycle>();
        public Bicycle()
        {

        }

        public Bicycle(int idN, string model, double price)
        {
            IdNumber = idN;
            Model = model;
            Cost = price;
            Console.WriteLine($"{IdNumber} - { Model}.  Rental price EUR {Cost}/hr");
        }
        public void PrintBikeInfo()
        {
            Console.WriteLine($"{IdNumber} - { Model}");
        }
        
        
        public string ChecksForBike(string model, int idNumber)
        {
            Bicycle bike = Bicycles.FirstOrDefault(bike => bike.IdNumber == idNumber);
            
                if (bike == null)
                {
                    return $"There is no bicycle under this {idNumber} ID Number!";
                }
            if (idNumber == IdNumber)
            {

            }
                return $"You have successfully rented a bike: {model}";
            
            return "";
        }
    }
}
