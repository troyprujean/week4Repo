using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Teacher : Employee
    {
        public string Office { get; set; }
        public Teacher(string _fname, string _lname, string _empid, string _office)
        {
            Fname = _fname;
            Lname = _lname;
            EmployeeId = _empid;
            Office = _office;
        }

        public string GetTeachDeets()
        {
            return $"\nFirst Name:{Fname}\nLast Name{Lname}\nEmployee ID: {EmployeeId}\nOffice: {Office}";
        }
    }

    
}
