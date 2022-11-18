using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)// Updated  Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
        {

            Employee employee = new Employee(); // instatiating my object
            employee.firstName = "Sample"; // initilizing the value of its properties
            employee.lastName = "Student";
            employee.SayName(); // calling my method

            // using polymorphism to create an object and call the Quit() method on it.
            employee.Quit();

            Console.ReadLine();
        }   

    }
}
