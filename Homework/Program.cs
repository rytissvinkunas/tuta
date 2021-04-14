using System;
using StringArray;
using NumbersArray;

namespace Homework
{
/*
     Programing Homework

     Work in the main function and complete the tasks:
    •	Create an array of string size 5. Fill array items with values.
    •	Print all words using loop.
    •	Create an int array size 20. Fill values from 0 till 20.
    •	Print numbers backwards.
*/

    class Program
    {
        public static readonly StringArrayMethods names = new StringArrayMethods();
        public static readonly NumbersArrayMethods numbers = new NumbersArrayMethods();
        static void Main(string[] args)
        {
            names.WordsArray();
            numbers.NumbersArray();
            Console.ReadLine();
        }
    }
}
