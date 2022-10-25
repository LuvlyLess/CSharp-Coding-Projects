using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                             String Assignment
            string hello = "Hello ";
            string quote = "The man said, \\ Hello\", Jesse. \n Hello New Lines \n \t Hello tabbed out. \n";
            string bye = "Good Bye and Good Luck obi one. to-uppercase ";
            string result = bye.ToUpper();
            Console.WriteLine(hello + quote + result);


            bool trueorfalse = hello.Contains("s");

            Console.WriteLine(trueorfalse);
            

            StringBuilder sb = new StringBuilder("Hello ", 50);

            sb.Append("Worldly humans ");
            sb.AppendLine("aliens, and germs! \n");
            sb.AppendLine("Your Journey Begins at the tippy top ");
            sb.AppendLine("of Mount Ego, 2000km above ");
            sb.AppendLine("C#, from wence the crones came, and left the land \"rotten to the core\" \n");
            sb.AppendLine("a Purge of their kin was Nessacery to protect the planet and its native inhabitants. ");
            sb.AppendLine("You may be unaware but YOU are the stain on an other wise perfect society. ");
            sb.AppendLine("For your words do not match your actions. This is your chance \n");
            sb.AppendLine("Act Accordingly! Germs! ");

            

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
