// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace HomeWorkOnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[][] inputArrays = new string[][]
            {
                new string[] {"Hello", "2", "world", ":-)"},
                new string[] {"1234", "1567", "-2", "computer science"},
                new string[] {"Russia", "Denmark", "Kazan"}
            };

            foreach (var array in inputArrays)
            {
                string[] result = FilterShortStrings(array);
                Console.WriteLine($"Input: [{string.Join(", ", array)}] → Output: [{string.Join(", ", result)}]");
            }
        }
        static string[] FilterShortStrings(string[] inputArray)
        {
            List<string> result = new List<string>();

            foreach (string str in inputArray)
            {
                if (str.Length <= 3)
                {
                    result.Add(str);
                }
            }
            return result.ToArray();
        }
    }
}

