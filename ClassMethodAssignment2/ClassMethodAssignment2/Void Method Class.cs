using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment2
{
    public class VoidClass
    {


        public void Method(int x )
        {
            
            int result = x / 2;
            Console.WriteLine(result);
                
                return;   
        }


        public int MethParams(int t, int r)
        {
            int Sum = t + r;
            return Sum + t + r;
        }

        public float MethParams(float x, float y)
        {
            return x * y;
        }

    }
}