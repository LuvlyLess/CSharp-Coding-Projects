using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    public class Optionalparameter //  creating a class that takes two integers with one being optional
    {
      
        public static int Optparam1(int a, int b = 1) // here i have created a parameter to accept  an optional param to be entered
        {
            Console.WriteLine("Enter a number: "); // asking use for input
            int userInput = Convert.ToInt32(Console.ReadLine()); // creating a instance of the user input
            int x = 52; // created a variable for x  to be used later

            Console.WriteLine("Pick another number optional ");// here is where i created the input/ output for the optional Parameter using an if loop
            int OptInput = Convert.ToInt32(Console.ReadLine());
            if (OptInput == 0) // if user input = 0 
            {
                Console.WriteLine(" No number entered \n"); // the console will wright  no number entered
                return a + x; 
            }
            else    // here it will continue on with the program doing a math operation 
            {
                Console.WriteLine("You numbers Plus 52 Equals ");
                 return a + b + x;
            }
           
        }
        
   } 
}
