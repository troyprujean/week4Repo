using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classExercises
{
    class Person
    {
        string firstName;
        string lastName;
        int age;
        string address;
        int phone;

        string GetFirstName()
        {
            return firstName;
        }

        string GetLastName()
        {
            return lastName;
        }

        int GetAge()
        {
            return age;
        }

        string GetAddress()
        {
            return address;
        }

        int GetPhone()
        {
            return phone;
        }

        public string GetDetails()
        {
            return $"{GetFirstName()} {GetLastName()} is {GetAge()} years old, their address is {GetAddress()} and phone number is {GetPhone()}";
        }

        public Person (string _fname, string _lname, int _age, string _add, int _ph)
        {
            firstName = _fname;
            lastName = _lname;
            age = _age;
            address = _add;
            phone = _ph;
        }
    }
}
