using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // a greeting message to start of the program
            Console.WriteLine("Greeting message here? \n");


            // creating an instance of my object
            Class1 classOne = new Class1();


            // Here is where i instantiate the class and call the methods()
            Console.WriteLine(classOne.Method1());
            Console.WriteLine(classOne.Method1(1, 2)); 
            Console.WriteLine(classOne.Method1("value"));
            Console.ReadLine();
        }
    }
}
