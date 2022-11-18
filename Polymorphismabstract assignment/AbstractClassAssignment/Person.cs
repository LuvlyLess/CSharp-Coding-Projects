using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person // creating an abstract class with two properties for my class Person
    {
        public string firstName { get; set; } // setting properties
        public string lastName { get; set; }
        
        

        public abstract void Name(); // adding a abstract method that states any class inheriting this class must implement this method
        // using a virtual allows you to override this method in its child class 
        public virtual void SayName() // the method that must be called in any child class that inherates from class person 
        {
            Console.WriteLine(firstName + " " + lastName);  // void method out put 
        }
   
    }
}
