using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms2NdPartNunitTesting
{
    internal class VendingMachine
    {
        public static void findChange()
        {

            Console.WriteLine("Enter the amount to find their change");
            int amount = Convert.ToInt32(Console.ReadLine());
            int[] notesInVendingMachine = { 1, 2, 5, 10, 50, 100, 500, 1000 };
            int numberOfAmount = 0;
            int notesIteration = notesInVendingMachine.Length - 1;
            while (amount > 0)
            {
                //numberOfAmount = amount % notesInVendingMachine[notesIteration];
                numberOfAmount = amount / notesInVendingMachine[notesIteration];
                if (numberOfAmount > 0)
                {
                    Console.WriteLine("Amount of Rupees: " + notesInVendingMachine[notesIteration] + ", Count of the cache: " + numberOfAmount);
                    amount = amount - (notesInVendingMachine[notesIteration] * numberOfAmount);
                }

                notesIteration--;
            }
        }
    }
}
