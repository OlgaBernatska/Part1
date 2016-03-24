using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernatska_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the array");
            int ArraySize = Int32.Parse(Console.ReadLine());
            int i = 0;
            int[] myArray = new int[ArraySize];
            for (i = 0; i < ArraySize; i++)
            {
                Console.WriteLine("Please input numbers. Press 'ENTER' after each number.");
                myArray[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Maximum value is " + myArray.Max());
            Console.WriteLine("Minimum value is " + myArray.Min());
            Console.ReadLine();
        }
    }
}