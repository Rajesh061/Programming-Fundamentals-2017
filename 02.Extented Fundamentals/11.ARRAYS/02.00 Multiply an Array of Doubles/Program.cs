﻿using System;
using System.Linq;
class Program
{
    static void Main() //100/100
    {
        double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double number = double.Parse(Console.ReadLine());

        foreach (var digit in array)
        {
            Console.Write(digit * number + " ");
        }
    }
}