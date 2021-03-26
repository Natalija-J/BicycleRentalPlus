using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_PartII
{
    class Students
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public double AvgMark { get; set; }

        public Students(string _name, string _lastname, int grade, double avg)
        {
            Name = _name;
            LastName = _lastname;
            Grade = grade;
            AvgMark = avg;

        }
        public Students()
        {

        }
    }
}
