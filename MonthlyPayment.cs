using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms2NdPartNunitTesting
{
    internal class MonthlyPayment
    {
        public static void calculatePayment()
        {
            Console.WriteLine("Please enter the principal amount");
            int principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the year");
            int year= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the rate of interest");
            int rate= Convert.ToInt32(Console.ReadLine());
            int payment = principal * rate * year / 100;
            Console.WriteLine("Total payment should be: "+ (payment+principal));
            
        }

        //public static int findPower(int num,int exp)
        //{
        //    int initVal = num;
        //    while(exp>1)
        //    {
        //        num = num* initVal; 
        //        exp--;
        //    }
        //    return num;
        //}
    }
}
