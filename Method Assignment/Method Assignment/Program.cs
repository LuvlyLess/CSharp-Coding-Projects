using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Method_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Optionalparameter Optparam = new Optionalparameter(); // creating an instance of my class
            
            Console.WriteLine("Enter a number: "); // asking use for input
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter another number optional "); // asking use for input

            try // using a trying catch to check if user input a number
            {
                int value2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Optionalparameter.Optparam1(value1 + value2));
            }
            catch // if user entered only one number call class  but only pass one number
            {
                Console.WriteLine(Optionalparameter.Optparam1(value1));
            }
            Console.ReadLine();
            

        }


    }
}
