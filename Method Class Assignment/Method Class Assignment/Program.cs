using Method_Class_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyClass MyClass = new MyClass(); // instantiate my class in Main() program
            MyClass.VoidMethod1(FirstNumber: 1, SecondNumber: 1); // Calling Class Method by name

            Console.ReadLine();
        }
    }
}

