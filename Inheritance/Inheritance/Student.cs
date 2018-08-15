﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public Student(string _fname, string _lname, int _stdid)
        {
            Fname = _fname;
            Lname = _lname;
            StudentId = _stdid;
        }

        public string GetStdtDeets()
        {
            return $"\nFirst Name:{Fname}\nLast Name:{Lname}\nStudent ID: {StudentId}";
        }
    }

   
}
