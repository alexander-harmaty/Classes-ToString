using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS426_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Create Document Class...");

            Document document1 = new Document("PhoneNumbers.txt", 3);
            Console.WriteLine("\t"+ document1.ToString());
            Document document2 = new Document("Report.txt", 30);
            Console.WriteLine("\t" + document2.ToString());

            //COMPILE ERROR: code below shows failed attempt to change static createdOn
            //document1.createdOn = DateTime.Now;

            Console.WriteLine("2) Create Employee Class...");

            Employee e1 = new Employee("Alex", "Smith");
            Employee e2 = new Employee("Mike", "Brown");
            Employee e3 = new Employee("Thomas", "Whitman");
            Employee e4 = new Employee("Alex", "Harmaty");
            Console.WriteLine("\t" + e1 + "\n\t" + e2 + "\n\t" + e3 + "\n\t" + e4);

            //Hold
            Console.WriteLine("\nPress any key to end program...");
            var i = Console.ReadLine();
        }
    }
}
