using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms2NdPartNunitTesting
{
    internal class Binary
    {
        public static void swapNibbles()
        {
            Console.WriteLine("Enter a number to convert into binary");
            int value = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine("Binary number of "+value+" is : "+binary);
            Console.WriteLine("Decimal of number is : " + Convert.ToString(value, 10));
        }
    }
}
