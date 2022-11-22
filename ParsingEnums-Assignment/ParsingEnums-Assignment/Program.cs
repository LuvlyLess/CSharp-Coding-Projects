using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try // wraping statement in try catch
            {

                Console.WriteLine("Please enter current day of the week");
                string day = Console.ReadLine();

                var day2 = (DayOftheWeek)Enum.Parse(typeof(DayOftheWeek), day); //Comparing the user input to the enum values
                Console.WriteLine(day2 + " is a day of the week");

            }
            catch
            {
                Console.WriteLine("Please Enter an actul day of the week");
                //  having it print "Please enter an actual day of the week.” to the console if an error occurs.
            }

            Console.ReadLine();
        

    }
        public enum DayOftheWeek // declaring my Enum List DaysOftheWeek, A list of constant values and variables
        {
            // Monday = 1;  // if you do not define the "index Number" it will always start at zero Monday,  would equal 0 "index number"
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
