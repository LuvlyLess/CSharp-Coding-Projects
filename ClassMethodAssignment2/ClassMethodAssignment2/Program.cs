using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment2
{
    class Program
    {

        static void Main(string[] args)
        {

            VoidClass InstantiateClass = new VoidClass(); // creating my class object in main program
            Console.WriteLine("Enter a number");  // asking for user input to console
            int UserInput = Convert.ToInt32(Console.ReadLine());  // taking user input and creating a object from it, UserInput = the users Input

           

            // Calling each method I created in  my void method class
            InstantiateClass.Method(UserInput); //Calling my Method to use it, on the user input 
            
            
            // calling my second method with int parameters
            Console.WriteLine(InstantiateClass.MethParams(5, 5));


            //Calling my third method Overload Method, it has the same name with different parameters ie (int and float)
            Console.WriteLine(InstantiateClass.MethParams((int)5.75F, (int)3.75F));


           

            Console.ReadLine();
        }
    }
}
