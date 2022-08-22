// Двухмерные массивы
//тип строк, количество
//string[,] table = new string[2, 5];
// строки исчисляются как и в массивах - с 06
// String.Empty
//table[1, 1] = "слово";
//for (int rows  = 0; rows < 2; rows++)
//{
//    for (int columns = 0; columns < 5; columns++)
//    {
//        Console.WriteLine($"-{table[rows, columns]}-");
//    }
//}
      
//matrix[1, 1] = 4;
//void PrintArray (int[,] matr)
//{
//    for (int rows  = 0; rows < matr.GetLength(0); rows++)
//    {
//        for (int columns = 0; columns < matr.GetLength(1); columns++)
//        {
//            Console.Write($"{matr[rows, columns]} ");
//        }
//        Console.WriteLine();
//    }
//}
//void FillArray (int [,] matr)
//{
//    for (int rows = 0; rows < matr.GetLength(0); rows++)
//    {
//        for (int columns = 0; columns < matr.GetLength(1); columns++)
//        {
//            matr[rows, columns] = new Random().Next(1, 10);
//        }    
//    }
//}
                    //строки
//int[,] matrix = new int[4,4];
                          //столбцы

//PrintArray(matrix);
//FillArray(matrix);
//Console.WriteLine();
//PrintArray(matrix);

//void PrintArray (int[,] matr)
//{
//    for (int rows  = 0; rows < matr.GetLength(0); rows++)
//   {
//        for (int columns = 0; columns < matr.GetLength(1); columns++)
//        {
//            Console.Write($"{matr[rows, columns]} ");
//        }
//        Console.WriteLine();
//    }
//}
// Задача следующая по "отлично"
//int[,] pic   = new int[5, 5];

//void PrintImage (int[,] image)
//{
//    for (int rows  = 0; rows < image.GetLength(0); rows++)
//    {
//        for (int columns = 0; columns < image.GetLength(1); columns++)
//        {
//            Console.Write($"{image[rows, columns]} ");
//            if (image[rows, columns] == 0) Console.Write($"+");
//            else Console.Write($"1");
//        }
//        Console.WriteLine();
//    }
//}
//void FillImage (int row, int columns)
//{
//   if(pic[row, columns] == 0)
//    {
//       pic[row, columns] = 1; 
//       FillImage(row-1, columns);
//       FillImage(row, columns-1);
//       FillImage(row+1, columns);
//       FillImage(row, columns+1);
//    }

//}
//PrintImage(pic);
//FillImage(2, 2);
//PrintImage(pic);

//double Factorial (int n)
//{
//    if (n == 1) return 1;
//    else return n * Factorial(n -1);
//}
//for (int i = 1; i < 40; i++)
//{
//    Console.WriteLine($"{i}!= {Factorial(i)}");
//}

//double Fibonacci (int n)
//{
//    if (n == 1 || n == 2) return 1;
//    else return Fibonacci(n-1) + Fibonacci(n-2);  
//}

//for (int i = 1; i < 40; i++)
//{
//    Console.WriteLine($"f{i}! = {Fibonacci(i)}");
//}



//Самостоеятельная работа


//int[] nums1 = new int[] { 0, 1, 2, 3, 4, 5 };
int[,] nums2 = {{ 0, 1, 2 }, { 3, 4, 5 }};
//matrix[1, 1] = 4;
//void PrintArray (int[,] nums2)
{
    for (int rows  = 0; rows < nums2.GetLength(0); rows++)
    {
        for (int columns = 0; columns < nums2.GetLength(1); columns++)
        {
            Console.Write($"--{nums2[rows, columns]}--");
                        
        }
        Console.WriteLine();
    }
}
//Console.WriteLine(nums1[1]);
//Console.WriteLine(nums2[1]);

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ira4
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = 0, ks = 0;
            int n, m;
            //заполняем двумерный массив
 
            Console.WriteLine("Введите количество строк и столбцов массива (m):");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество строк и столбцов массива (n):");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементы массива:");
            int[,] ira = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    ira[i, j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(" " + ira[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
 
            //определяем количество строк, не содержащих ни одного нулевого элемента
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (ira[i, j] == 0)
                        k++;
                }
                if (k == 0)
                    ks++;
 
                else
                    k = 0;
            }
            Console.WriteLine("количество строк, не содержащих ни одного нулевого элемента = " + ks);
 
            int max = 0, kol = 0;
            max = ira[0, 0];
            kol = 1;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (max <= ira[i, j])
                    {
                        for (int x = 0; x < m; x++)
                            for (int y = 0; y < n; y++)
                                if ((ira[i, j] == ira[x, y]) && (i != x || j != y))
                                {
                                    max = ira[i, j];
                                    kol++;
                                }
                    }    
            if (kol != 1)
                Console.WriteLine("\nМаксимальное из чисел, встречающихся в заданной матрице более одного раза: " + max);
            else
                Console.WriteLine("Нету повторяющихся чисел");
            Console.ReadLine();
 
        }
    }
}