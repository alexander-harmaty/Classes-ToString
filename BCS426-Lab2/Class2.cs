using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS426_Lab2
{
    class Employee
    {
        private static int nextAvailableID;
        private String firstName;
        private String lastName;
        private readonly int iD;

        static Employee()
        {
            nextAvailableID = new Random().Next(1, 9999);
        }
        public Employee(String fn, String ln)
        {
            firstName = fn;
            lastName = ln;
            iD = nextAvailableID;
            nextAvailableID++;
        }
        public override string ToString()
        {
            return "First name: " + firstName + " ,Last name: " + lastName + ", ID: " + iD;
        }
    }
}
