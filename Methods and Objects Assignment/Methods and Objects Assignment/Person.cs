using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    public class Person
    {
        //setting two properties  first name and last name, for Class "Person"
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public void SayName() // creating a void method to be called by Inheritance
        {
            string Name = FirstName + " " + LastName; 
            Console.WriteLine(Name);
        }

    }
}
