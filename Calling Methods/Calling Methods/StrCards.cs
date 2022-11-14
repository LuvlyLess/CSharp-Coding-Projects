using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    public class MathAintMathin
    {
        //  assigning values and methods to my  Object class 
        // i need to create 2 more methods in the same class?

        public  MathAintMathin() // Building a Class , with 3 methods 
        {

            Console.WriteLine(" Call me the Maffs Master \n ");

        }

        public static int Method1()  // class Method one 
        {
            int maffsOne = 18;   // adding value to my  Method Object, i know thats not the correct termonology 
            return maffsOne;
           
        }

        public static int Method2() // class method 2 
        {
            int myMaffs = 10;  // Adding value to my Object
            return myMaffs;

        }



        public int Method3()    // Adding value to my Object
        {

            int maffMaster = 77;
            return maffMaster;
        }



        // Setting class Properties
        public int maffsOne { get; set; } 
        public int userInputMaffs { get; set; } 

        public int myMaffs { get; set; }
        public int userMaffs { get; set; }

        public int maffMaster { get; set; }
        public int InputMaster { get; set; }

    }
}













