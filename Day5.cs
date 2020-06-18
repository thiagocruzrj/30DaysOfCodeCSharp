using System;

namespace DaysOfCodeCSharp
{
    class Day5 {
        static void Main(string[] args) {
            var N = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i ++)
            {
                Console.WriteLine($"{N} x {i} = {N * i}");
            }
        }
    }
}