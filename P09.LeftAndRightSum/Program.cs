﻿using System;

namespace P09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum1 += a;
            }

            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum2 += a;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
