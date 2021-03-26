using System;

namespace Day4_PartIII
{
    class Program
    {
        static void Main(string[] args)
        {

            Operations org = new Operations("SIA mans uznemums");

            org.AddNew("Kaija", "Putnina", 1980);            
            org.AddNew("Dzidra", "Zupa", 1979);            
            org.AddNew("Rudolfs", "Briedis", 1983);

            Console.WriteLine();
            Console.WriteLine("Here is the First List of employees: ");
            foreach (var person in org.Print())
            {
                Console.WriteLine("{0} {1} (DOB: {2})", person.Name, person.LastName, person.BirthYear);
            }
            Console.WriteLine();
            string fired = org.Fire("Dzidra", "Zupa");
            Console.WriteLine(fired);
            Console.WriteLine();
            
            string changeDate = org.ChangeData("Rudolfs", "Briedis", 1973);
            Console.WriteLine(changeDate);
            Console.WriteLine();
            Console.WriteLine("Here is the Second/Updated List of employees: ");
            foreach (var person in org.Print())
            {
                Console.WriteLine("{0} {1} (DOB: {2})", person.Name, person.LastName, person.BirthYear);
            }
                
        }
    }
}
