using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Printing greetings to the Main program
            Console.WriteLine(" Welcome to the ... Magic Math Show ?!? \n " );
            // end of greeting
           
            // Asking for user input
            Console.WriteLine(" What Number would you like to do an Magic trick on ? ");
            int myMethodCall = Convert.ToInt32(Console.ReadLine());

            // call my methods to the main prgram to do math operations on

            // Calling my Object to the Main Program 
            MathAintMathin math = new MathAintMathin();

            // Calling Method 1 to Multiply User Input by 18
            Console.WriteLine(" Your Math  Return Value for Method 1 is ");
            Console.WriteLine(MathAintMathin.Method1() * myMethodCall);


            // Calling Method 2 to Minus 10 from User Input
            Console.WriteLine(" Your Math  Return Value for Method 2 in ");
            Console.WriteLine(math.Method3() - myMethodCall);


            //Calling Method 3 to Add +77 to the Users Input
            Console.WriteLine(" Your Math  Return Value for Method 3 is ");
            Console.WriteLine(math.Method3() + myMethodCall);

            Console.ReadLine(); // I know there is a prettier way to write this code but my maffs Aint Maffin :)
        }
    }
}
