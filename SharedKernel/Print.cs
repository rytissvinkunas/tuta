using System;
using System.Collections.Generic;
using System.Text;

namespace SharedKernel
{
    public static class Print
    {
        public static void PrintArray<T>(T[] arr)
        {
            int count = 0;
            foreach (var i in arr)
            {
                Console.WriteLine($"Array element #{count}: {i}");
                count++;
            }
        }
    }
}
