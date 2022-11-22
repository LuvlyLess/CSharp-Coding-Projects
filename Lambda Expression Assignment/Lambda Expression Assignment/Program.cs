using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Lambda_Expression_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();// Employee object


           List<Employee> empList = new List<Employee>(); // creating my employee List(emplist) and giving it value of the Class Employee
            empList.Add(new Employee() { FirstName = "Joe", Id = 1, LastName = "Smith" }); // Giving my List of employees values for each property
            empList.Add(new Employee() { FirstName = "Cris", Id = 2, LastName = "Benny" });
            empList.Add(new Employee() { FirstName = "Sally", Id = 3, LastName = "Eggston" });
            empList.Add(new Employee() { FirstName = "Jesse", Id = 4, LastName = "Strumin" });
            empList.Add(new Employee() { FirstName = "Joe", Id = 5, LastName = "Carter" });
            empList.Add(new Employee() { FirstName = "Sue", Id = 6, LastName = "Chaslin" });
            empList.Add(new Employee() { FirstName = "Johanson", Id = 7, LastName = "Truman" });
            empList.Add(new Employee() { FirstName = "Opera", Id = 8, LastName = "Chance" });
            empList.Add(new Employee() { FirstName = "Harvey", Id = 9, LastName = "Black" });
            empList.Add(new Employee() { FirstName = "Joel", Id = 10, LastName = "Dene" });

            // Using foreach Loop
            foreach (var emp in empList) // creating a foreach/for loop to step through my List Employee and find matching Name of "Joe"
            {
                if (emp.FirstName == "Joe")
                {                  
                    List<Employee> empJoe = new List<Employee>();// creating my List of Joe's
                    empJoe.Add(emp); // Adding the values"Joes" to my list
                   Console.WriteLine(emp.FirstName + " " + emp.LastName + " " + emp.Id); // printing each property of each Joe to the console
                }
                
            }
            // Using Lambda function
            List<Employee> employeeList2 = empList.Where(emp => emp.Id > 5).ToList(); // Using lambda i checked the list to find how many employees hav an ID # above 5

            Console.WriteLine(employeeList2.Count);// here i printed the value"Count" of the lambda function 


            Console.ReadLine();
        }
    }
}
