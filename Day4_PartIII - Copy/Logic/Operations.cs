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
        }

        public string AddNew(string name, string surname, DateTime year)
        {
            
            Employee newEmp = new Employee()
            {
                Name = name,
                LastName = surname,
                BirthYear = year
            };

            if (newEmp != null)
            {
                Organisation.AddNew(name, surname, year);
            }
            return $"Employee added: {newEmp.Name.Substring(0,1)}. {newEmp.LastName}.";
        }
        public string ChangeData(string name, string surname, DateTime year)
        {
            Employee updateEmp = Organisation.Employees.Find(i => i.Name.ToLower() == name.ToLower() 
                                                            && i.LastName.ToLower() == surname.ToLower());
            
                updateEmp.BirthYear = year;
            
            return $"Changed {updateEmp.Name.Substring(0, 1)}. {updateEmp.LastName} date of birth to {year}.";
        }

        public string Fire(string name, string surname)
        {
            Employee toFire = Organisation.Employees.FirstOrDefault(i => i.Name.ToLower() == name.ToLower()
                                                                    && i.LastName.ToLower() == surname.ToLower());                                                       );
            Employee fired = Organisation.Employees.Remove(toFire);

            return $"Employee fired: {toFire.Name.Substring(0, 1)}. {toFire.LastName}";
        }
        public List<Employee> Print()
        {
           
            return Organisation.Employees.OrderBy(person => person.Name).ThenBy(person => person.LastName).ToList(); 

        }

    }
}
