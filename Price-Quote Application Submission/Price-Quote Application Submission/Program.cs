using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Quote_Application_Submission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                                                         Price-Quote Application Submission

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \n");
            Console.WriteLine("\n Please Enter Package Weight in Pounds. \n");
            
            
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            int weightLimit = 50;

            if (packageWeight > weightLimit)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day. \n"); 
                Console.ReadLine();
            }
            else if (packageWeight < weightLimit)
            {
                Console.WriteLine("Please Enter Package width. \n");
                int pkgWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter Package Height. \n");
                int pkgHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter Package Length. \n");
                int pkgLength = Convert.ToInt32(Console.ReadLine());

                int totalDimension = Convert.ToInt32 (pkgWidth + pkgHeight + pkgLength);

                if (totalDimension > weightLimit)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. ");
                }
                else if (totalDimension < weightLimit)
                {
                    int totalSize = (pkgWidth * pkgHeight * pkgLength); 
                    
                    decimal priceQuote = totalSize * packageWeight / 100; 
                    
                    Console.WriteLine("Your Price Quote is \n" + priceQuote);
                    Console.ReadLine();
                }

            }

        }
    }
}
