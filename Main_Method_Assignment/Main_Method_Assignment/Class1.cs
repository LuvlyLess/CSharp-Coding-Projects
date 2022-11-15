using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    public class Class1
    {
        public int Method1() // here i have created my first Method() to be used or called from the main program
        {
            Console.WriteLine("I'm adding 23 to your: user input \n");
            Console.WriteLine("Please pick a number ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int addingTo = 23;
            return addingTo + userInput;
        }


        public float Method1(float x, float y ) // here i have created a second Method() that multiplies Your Input number by 18% and returns the Value
            // think i wanna add an exception message here
        {
            
            Console.WriteLine("Please pick a number ");
            float userInput2 = Convert.ToSingle(Console.ReadLine());
            float Percent = 0.18f; // this is the same as 18%
            
            float Amount = userInput2 * Percent;

            return Amount;
        }

        public string Method1(string value) // creating a third class with parameters that converts a string to int 
        {

            string str = "100 Plus";

            try // i used a try catch for format exception
            {
                int x = Convert.ToInt32(str);
                Console.WriteLine(x);
            }
            catch (FormatException)
            {
                Console.WriteLine(" Input string is invalid.");
            }
            return str + 10;
        }








    }
}
