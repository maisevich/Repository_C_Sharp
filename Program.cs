using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Форматируем шапку программы
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("*********************************************");
            Console.WriteLine("**** Первый проект Александра Мойсевича !****");
            Console.WriteLine("*********************************************");
            // Основная программа
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Hello, World!");

            // Ожидание нажатия клавиши Enter перед завершением работы
            Console.ReadLine();
        }
    }
}

