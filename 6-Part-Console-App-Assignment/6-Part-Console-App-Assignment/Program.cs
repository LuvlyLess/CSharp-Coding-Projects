using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Threading;

namespace _6_Part_Console_App_Assignment
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            //                         Six-Part Assignment

            // Assignment Part 1

            //int i;
            //int[] arr = new int[5]; // 5 size array

            //// Accepting value from user 
            //for (i = 0; i < 5; i++)
            //{
            //    Console.Write("\nEnter your number:\t");
            //    //Storing value in an array
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("\n\n");
            ////Printing the value on console
            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("you entered {0}", arr[i]);
            //    // Delay that prints off each string of an array one at a time.
            //    Thread.Sleep(2000);

            //}
            //Console.ReadLine();



            //  Console App Assignment Part 2 
            //An infinite loop. Fix the infinite loop so that it will execute properly.


            // Creating infinite loop
            // using while loop
            //while (true)
            //{

            //    // This statement will be printed
            //    // infinite times
            //    Console.WriteLine("Civilized people will tell you that you're fat and poor and you were never Beautiful \n Then tweet about how much they love you, when they hear about your funeral \n ");

            //}
            //Console.ReadLine();

            // Console App Assignment Part 2 Fixed
            //An infinite loop, Fixed.

            //int i = 0;
            //while (i < 5 ) // Here is where i fixed the infinite loop to a limited amount of runs, i set it to 5
            //{
            //    Console.WriteLine("Civilized people will tell you that your fat and poor and you were never Beautiful \n Then tweet about how much they love you, when they hear about your funeral \n");
            //    i++;
            //}
            //Console.ReadLine();


            // Console App Assignment Part 3




            // Here is where i declare an array 
            //int[] AppAss3 = { 12, 14, 16, 18, 20, 21, 22, 23, 24, 25 };
            //foreach (int i in AppAss3) 
            //{
            //    Console.WriteLine(i < 25); // useing the less than operator (<) to find out if i is less than 25

            //    if (i <= 18) // useing the less than operator (<=) to find out if i is less than 18
            //    {
            //        Console.WriteLine("This compairson is Less than or Equal to 18 \n "); // if i is less than or equal too 18 Console will print
            //    }    
            //    else if (i <= 25) // useing the less than operator (<=) to find out if i is less than 25
            //    {
            //        Console.WriteLine("This comparison is Les than or Equal to 25 \n "); // if i is less than or equal to 25 console will print 
            //    }
            //}
            // Console.ReadLine();

            //Console App Assignment Part 4



            //List<string> Brands = new List<string>(10); // This is my declared variable List of the top Clothing brands of 2022
            //Brands.Add("Nike");
            //Brands.Add("Addidas");
            //Brands.Add("Rebox");
            //Brands.Add("Gucci");
            //Brands.Add("LaCost");
            //Brands.Add("Columbia");
            //Brands.Add("Louis Vuitton");
            //Brands.Add("Chanel");
            //Brands.Add("The North Face");
            //Brands.Add("Puma");
            //Brands.Add("Lululemon");
            //Brands.Add("Levi's");
            //Brands.Add("Ray-Ban");
            //Brands.Add("Dior");
            //Brands.Add("Burberry");

            //Console.WriteLine("What is your favorite Brand clothing");
            //string userBrandName = Console.ReadLine();   // I used Console.ReadLine() to get user input 

            //if (Brands.Contains(userBrandName))  // This If statement specifys a block of code to be executed, if a specified condition is true
            //{               
            //    Console.WriteLine("Found " + userBrandName); // if true console will write the Brand that matches the User Input
            //}
            //else
            //{
            //    Console.WriteLine("Not Found in List of Clothing Brands"); // this block tells the user their input is not on the list. if there is no match in my array list
            //}
            // Console.ReadLine();


            // Console App Assignment Part 5


            //List<string> groceryList = new List<string> { "milk", "butter", "eggs", "milk", "apples" };  // Here i have declared a variable that holds an array of strings

            //Console.WriteLine("enter a food product");
            //string ProductCheck = Console.ReadLine(); // asking for user input to compare to my array
            //int count = 0; 

            //foreach (string grocery in groceryList)  // This is my For Loop that compares user input to my array by iterating through each item in array
            //{
            //    if (ProductCheck == grocery) // If statement that uses , user input to check if the element is in my array and output the index of duplicate strings  
            //    {
            //        Console.WriteLine("Index of " + grocery + " found duplicate items at " + count); 
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your Item is not on the grocery List");
            //    }
            //    count++;
            //}
            //        Console.ReadLine();


            List<string> Identicalnames = new List<string> { "Christine", "smith", "Amber", "Christopher", "Mathew", "martin", "miller", "mark", "mark" }; //i declared a variable that holds an array of strings
            Console.WriteLine("checking for duplicate names \n"); // Informing User of programs intentions
            



                foreach (string Identicalname in Identicalnames)// foreach loop searching for duplicate elements
            {
                if (Identicalname.Distinct().Count() == 4) // here ive taken a risk and made my if statement based on no one having a short name but mark 
                {
                    Console.WriteLine("This Items Not Unique "  + Identicalname); // This is My console output for common names (ie) mark.
                }
                else
                {
                    Console.WriteLine("This item is Unique" + Identicalname); // This is my console out put for Unique names.
                }
            }
                Console.ReadLine();



        }
    }
}