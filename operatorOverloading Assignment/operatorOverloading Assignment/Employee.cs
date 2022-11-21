using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloading_Assignment
{
    public class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



        // operator overloading is the overloading of the built in operators in C#.
        public static bool operator ==(Employee emp1, Employee emp2)
        {

            if  (emp1.Id == emp2.Id) // using (if) to see if the employee.Id match               
            {
                return true;
            }
            return false;

        }
        public static bool operator !=(Employee emp1, Employee emp2) 
        {

            if (emp1.Id == emp2.Id) // using (if) to see if the employee.Id match               
            {
                return true;
            }
            return false;

        }


    }


    
}
