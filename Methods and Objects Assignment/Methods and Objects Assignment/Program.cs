using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //inheraitance 
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1 }; // createing my employee and initilizing with values

            employee.SayName(); // calling my void method , by Inheritance (Derived and Base Class) to the console

            Console.ReadLine();
        }
    }
}
