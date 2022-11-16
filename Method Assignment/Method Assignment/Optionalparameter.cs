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
      
        public static int Optparam1(int value1, int value2 = 1) // here i have created a parameter to accept  an optional param to be entered
        {
           Console.WriteLine("You numbers Plus 52 Equals ");
                 return value1 + value2;
  
        }
        
   } 
}
}
