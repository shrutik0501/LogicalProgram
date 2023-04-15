using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms2NdPartNunitTesting
{
    internal class TemperatureConversion
    {
        public static void tempConvert()
        {
            Console.WriteLine("Please enter your choice of conversion");
            Console.WriteLine("Press 1 for celsious to fahrenheit ");
            Console.WriteLine("Press 2 for fahrenheit to celsious ");
            int choice = Convert.ToInt32(Console.ReadLine());
            int input;
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter the value in celsious");
                    input= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Value after conversion into Fahrenheit is: "+((input*9/5) + 32));
                    break;
                case 2:
                    Console.WriteLine("Enter the value in Fahrenheit");
                    input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Value after conversion into celsious is: " + ((input -32) * 5 / 9));
                    break;
            }
        }
    }
}
