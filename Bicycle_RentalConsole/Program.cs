using Bicycle_Rental;
using Bicycle_Rental.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace Bicycle_Rental
{
    class Program
    {
        static void Main(string[] args)
        {
            Rental manager = new Rental();
            //Console.WriteLine("Available Bikes are: ");
            //foreach (var bike in manager.AvailableBikes())
            //{
            //    Console.WriteLine("ID nr.: {0} - {1}.  Cost: EUR {2}", bike.IdNumber, bike.Model, bike.Cost);
            //}
            while (true)
            {
              
                Console.Write("Enter rental period (hours): ");
                int time = int.Parse(Console.ReadLine());                            
                Console.Write("Enter bicycle ID number to rent: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Enter your email address: ");
                string email = Console.ReadLine();
                Console.WriteLine();

                if (IsEmailValid(email))
                {
                    var customer = manager.AddRenter(email, time);
                    var bike = manager.AddToUser(number);
                    
                    if (bike == null)
                    {
                        Console.WriteLine("We do not have the bicycle you have selected.");
                    }
                    

                    Console.WriteLine("Would you like to make another reservation? (yes/no): ");
                    string input = Console.ReadLine();
                    if (input == "no" || input == "n" || input == "NO" || input == "N")
                    {
                        break;
                    }
                }
            
                else
                {
                Console.WriteLine("Please enter a valid email address!");
                }
            }
            Console.WriteLine("You total prices is: EUR {0}", manager.CheckOut());
            Console.WriteLine("Thank you for choosing our Bike Rental Shop!");
            Console.WriteLine("Here is the list of your purchase: ");
            foreach (var bike in manager.CompleteTransaction())
            {
                Console.WriteLine($"{bike.Model} bicycle was rented");
            }
            Console.Read();
        }

        private static bool IsEmailValid(string email)
        {
            
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
