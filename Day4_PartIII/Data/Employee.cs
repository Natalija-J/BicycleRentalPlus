using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_PartIII
{
    public class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public Employee()
        {

        }

        public Employee(string name, string surname, int year)
        {
            Name = name;
            LastName = surname;
            BirthYear = year;
        }
        public Employee(string name, string surname)
        {
            Name = name;
            LastName = surname;
        }
    }
}
