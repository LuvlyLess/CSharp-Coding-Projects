using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    public class MyClass
    {
        
        public static void VoidMethod1(int FirstNumber, int SecondNumber) // creating named parameters to be called by name on Main() program
        {
            Console.WriteLine( FirstNumber + 4 + " int X = 1 plus Four Equals five");
            Console.WriteLine("Displaying second int y Equals " + SecondNumber);
            Console.WriteLine(FirstNumber + " Passing Both ints " + SecondNumber);
        }

        internal void VoidMethod1(object y)
        {
            throw new NotImplementedException();
        }
    }
}
