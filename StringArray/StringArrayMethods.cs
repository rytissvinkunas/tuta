using System;
using System.Collections.Generic;
using System.Text;
using SharedKernel;

namespace StringArray
{
    public class StringArrayMethods
    {

        private readonly string[] Words = new[]
        {
            "Cat", "Dog", "Bird", "Fly", "Bee"
        };

        public void WordsArray()
        {
            Console.WriteLine("1 TASK: Create an array of string size 5. Fill array items with values. Print all words using loop.");
            Console.WriteLine(" ");
            Print.PrintArray(Words);
            Console.WriteLine(" ");
        }
    }
}
