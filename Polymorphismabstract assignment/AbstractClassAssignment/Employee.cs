using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{                         // implementing my interface
    public class Employee : Person, IQuittable // creating a employee class that inherits its properties from the abstract Class Person
    {
        public override void SayName()
        {
            base.SayName();
        }

        public override void Name()   // using override 
        {
            throw new NotImplementedException();
        }

        public void Quit() 
        {
            Console.WriteLine("Fake Quit: Option ");
            throw new NotImplementedException();
        }
        


    }
}
