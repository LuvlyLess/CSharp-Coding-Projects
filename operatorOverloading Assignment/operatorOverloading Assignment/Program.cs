using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloading_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {

            // creating two employees to compare .Id properties
            Employee emp1 = new Employee();
            emp1.Id = Convert.ToString(1);
            emp1.FirstName = "Chester";
            emp1.LastName = "Bennington";

            Employee emp2 = new Employee();
            emp2.Id = Convert.ToString(12);
            emp2.FirstName = "John";
            emp2.LastName = "MacAfee";

            if (emp1.Id == emp2.Id) // using if to  write response if == || != a match 
            {
                Console.WriteLine("The Id Matches");
            }
            else
            {
                Console.WriteLine("The Id does not match");
            }

            Console.ReadLine();
        }
    }
}
