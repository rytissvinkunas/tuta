using System;
using System.Collections.Generic;
using System.Text;
using SharedKernel;

namespace NumbersArray
{
    public class NumbersArrayMethods
    {

        private readonly int[] Numbers = new[]
        {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20
        };

        public void NumbersArray()
        {
            Console.WriteLine("2 TASK: Create an int array size 20. Fill values from 0 till 20. Print numbers backwards.");
            Console.WriteLine(" ");
            Console.WriteLine("Original array has:");
            Print.PrintArray(Numbers);
            Console.WriteLine(" ");
            Console.WriteLine("Reversed array has:");
            Array.Reverse(Numbers);
            Print.PrintArray(Numbers);
        }
    }
}
