using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms2NdPartNunitTesting
{
    internal class SquareRoot
    {
        public static void findSquareRoot()
        {
            Console.WriteLine("Enter a number to find square root");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square root of the number is : "+Math.Sqrt(num));
        }
    }
}
