using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person // creating a employee class that inherits its properties from the abstract Class Person
    {
        public override void SayName() 
        {
            base.SayName();
        }


        public override void Name()   // using override keyword to define the method the abstract method 
        { 
             throw new NotImplementedException();
        }
    }
}
