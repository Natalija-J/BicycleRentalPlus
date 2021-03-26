using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day4_PartIII
{
    class Operations
    {
        public Employee Employee { get; set; }
        private Organisation Organisation { get; set; }
        public Operations(string name)
        {
            Employee = new Employee();
            Organisation = new Organisation(name);
            Console.WriteLine("Organisation '{0}' has been established!", name);
        }

        public string AddNew(string name, string surname, int year)
        {
            
            Employee newEmp = new Employee()
            {
                Name = name,
                LastName = surname,
                BirthYear = year
            };

            if (newEmp != null)
            {
                Organisation.AddNew(newEmp.Name, newEmp.LastName, newEmp.BirthYear);
                return $"Employee added: {newEmp.Name.Substring(0, 1)}. {newEmp.LastName}" +
                    $" (DOB: {newEmp.BirthYear}).";
            }
            return "Employee could not be added.";
        }
        public string ChangeData(string name, string surname, int year)
        {
            Employee updateEmp = Organisation.Employees.Find(i => i.Name.ToLower() == name.ToLower() 
                                                       && i.LastName.ToLower() == surname.ToLower());
            
            updateEmp.BirthYear = year;
            
            return $"Changed {updateEmp.Name.Substring(0, 1)}. {updateEmp.LastName} birht year to {year}.";
        }

        public string Fire(string name, string surname)
        {
            Employee toFire = Organisation.Employees.FirstOrDefault(i => i.Name.ToLower() == name.ToLower()
                                                              && i.LastName.ToLower() == surname.ToLower());
            Organisation.Employees.Remove(toFire);

            return $"Employee fired: {toFire.Name.Substring(0, 1)}. {toFire.LastName}";
        }
        public List<Employee> Print()
        {
           return Organisation.Employees
                                .OrderBy(person => person.Name)
                                .ThenBy(person => person.LastName)
                                .ToList();
        }
    }
}
