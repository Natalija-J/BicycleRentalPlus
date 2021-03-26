using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_PartIII
{
    class Organisation
    {
        private string Name { get; set; }
        public List<Employee> Employees { get; set; }
       
        public Organisation(string name)
        {
            Name = name;
            //when there is a list - 
            //initialize this to avoid Null error:
            Employees = new List<Employee>();
        }

        public void AddNew(string name, string surname, int year)
        {
            // 'Employees' variable is of 'class scope' -> property
            Employees.Add(new Employee()
            {
                Name = name,
                LastName = surname,
                BirthYear = year
            });

            // new variable 'employees' not related to var 'Employees'
            // 'employees' is of 'method scope'
            var employees = new List<Employee>();
            employees.Add(new Employee()
            {
                Name = name,
                LastName = surname
            });
        }

        
    }
}
