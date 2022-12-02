using addaname;
using System.Data.Entity;
using System;

namespace addaname
{
    class program
    {
        static void Main(string[] args) 
        {
            
            using (var db = new StudentContext())
            {
                //  user input
                Console.WriteLine("Please Enter First Name");
                var firstname = Console.ReadLine();
                Console.WriteLine("Please Enter Last Name");
                var lastname = Console.ReadLine();
                Console.WriteLine("Please Enter Country");
                var country = Console.ReadLine();

                Student student = new Student();
                student.FirstName = firstname;
                student.LastName = lastname;
                student.Country = country;
                
                db.Students.Add(student);
                db.SaveChanges();


                var query = from b in db.Students
                orderby b.LastName
                select b;
                foreach (var item in query) { Console.WriteLine(item.FirstName); }
            }

        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Country { get; set; }
        
        
    }





   public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

    }

}
