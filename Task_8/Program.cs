﻿namespace Homework
{
    // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    class Program
    {        static void Main (string[]args)
        {
            Console.WriteLine ("Введите число n");
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.Write(i + " ");
                }
            }
        }
      
    }
}    
