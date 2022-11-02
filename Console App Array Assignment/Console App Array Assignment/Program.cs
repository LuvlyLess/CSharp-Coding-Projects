using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Configuration;

namespace Console_App_Array_Assignment
{
        class Program
    {
        static void Main()
        {
            //   one-dimensional Array of integers. User select an index of the Array and then display the integer at that index on the screen.
            try  // Any suspected code that may raise exceptions should be put inside a try{ } block. During the execution, if an exception occurs, the flow of the control jumps to the first matching catch block.
            {
                double[] cisTuition = new double[] { 0.00, 1.00, 1.50, 2.00, 2.50 }; // One dimentional Array of Int
                Console.WriteLine("Please choose a number between 0 - 4");

                int index1 = int.Parse(Console.ReadLine());           // index Parse to Console
                Console.WriteLine("value is: " + cisTuition[index1]);    // User Index input selection

            }
            catch (Exception e)   // Try Catch exception for a message that displays when the user selects an index that doesn’t exist
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();       // User Value Output




            try   // Any suspected code that may raise exceptions should be put inside a try{ } block. During the execution, if an exception occurs, the flow of the control jumps to the first matching catch block.
            {
                string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" }; // one-dimensional Array of strings. user selects an index of the Array and then display the string at that index on the screen.       
                Console.WriteLine("Pick a number between 0 - 6");
                int index = int.Parse(Console.ReadLine());     // index Parse to Console
                Console.WriteLine("Value is: " + weekDays[index]);   // User Index input selection

            }

            catch (Exception e)    // Catch exception for a message that displays when the user selects an index that doesn’t exist

            {
                Console.WriteLine(e.Message);
            }


            //                                                                      Arrays and Lists

            // Creates and initializes a new ArrayList.
            try
            { 
            ArrayList myList = new ArrayList();
            myList.Add("Hello World");
            myList.Add("Hey World");
            myList.Add("World Wide!");

            Console.WriteLine("Welcome, Pick a number between 0 - 2 \n ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Value is: " + myList[index]);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



            Console.ReadLine();
            }
        }
    }
