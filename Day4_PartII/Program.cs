using System;
using System.Collections.Generic;
using System.Linq;

namespace Day4_PartII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            
            students.Add(new Students("John", "Smith", 5, 8.5));
            students.Add(new Students("Ann", "Smith", 5, 6.0));
            students.Add(new Students("George", "Bounty", 4, 7.33));
            students.Add(new Students("Robert", "Bobby", 4, 9.0));
            students.Add(new Students("Joe", "Average", 4, 7.0));
            students.Add(new Students("Lisa", "Doe", 5, 7.5));

            //6.1. Print out all the students ordered by the surname (asc) and then by the name (asc)
            var listAlphabeticallyLastName = students.OrderBy(i => i.LastName).ThenBy(i => i.Name).ToList();
            Console.WriteLine("6.1: All the students ordered by the surname and then by the name: ");
            foreach (var student in listAlphabeticallyLastName)
            {
                Console.Write(student.Name + " " + student.LastName);
                Console.WriteLine();
            }
            //Console.WriteLine();
            //Console.WriteLine();
            //var listByName = students.OrderBy(i => i.Name).ToList();
            //Console.WriteLine("6.1 All the students ordered by their name: ");
            //foreach (var student in listByName)
            //{
            //    Console.Write(student.Name + " ");
            //}
            Console.WriteLine();
            Console.WriteLine();

            //6.2.Print out all the students in the class 5
            Console.WriteLine("6.2 All the students who are in the 5th class: ");
           var StudentsInFive = students.Where(st => st.Grade == 5).ToList();

            foreach (var student in StudentsInFive)
            {
                Console.WriteLine(student.Name + " " + student.LastName);
            }
            Console.WriteLine();
            Console.WriteLine();

            //6.3. Print out all the students with avg.grade greater than or equal to 8.
            Console.WriteLine("6.3 All the students with average grade greater than or equal to 8: ");
            var highAvg = students.OrderBy(i => i.AvgMark).ToList();
            foreach (var student in highAvg)
            {
                if (student.AvgMark >= 8)
                {
                    Console.WriteLine(student.Name + " " + student.LastName);
                }
            }

            var averageGr = students.Average(st => st.AvgMark);
            Console.WriteLine($"The average mark of the students is: {averageGr}");
            Console.WriteLine();
            Console.WriteLine();

            //6.4. Print out the student with the highest grade in class 4.
            Console.WriteLine("6.4 The student with the highest grade in class 4: ");
            var best = students.Where(st => st.Grade == 4).OrderByDescending(st => st.AvgMark).First();
            Console.WriteLine(best.Name + " " + best.LastName);

            var highestScore = students.Where(st => st.Grade == 4).Max(students => students.AvgMark);
            var studentBest = students.Find(st => st.Grade == 4 && st.AvgMark == highestScore);

            var bestSt = students.FirstOrDefault(st => st.Grade == 4 && st.AvgMark == highestScore);

            // WHERE vs FIND
            // Use WHERE if result is multiple records
            // Use FIND if result is one record
            // -- returns NULL if no matching element

            // FIRST vs FIRSTORDEFAULT
            // Use FIRST if you know there will be a matching record
            // -- throws error if no matching element
            // Use FIRSTORDEFAULT if you don't know if any records satisfy criteria
            // -- returns NULL if no matching element

            // FIND vs FIRSTORDEFAULT
            // No difference

            Console.WriteLine();
            Console.WriteLine();

            //6.5. Print out the average grade for class 5.
            Console.WriteLine("6.5 The average grade for class 5 is: ");
            //var averageF = students.OrderBy(i => i.Grade).ToList();
            
            var averageF = students.Where(st => st.Grade == 5).Average(st => st.AvgMark);
            
            Console.WriteLine(averageF);
        }

    }
}
