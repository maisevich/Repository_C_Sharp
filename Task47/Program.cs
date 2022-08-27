//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Введите число строк для массива = ");
int stringsArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите число столбцов для массива = ");
int columnsArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[,] arrayNumbers = new double[stringsArray, columnsArray];

void PrintArray (double[,] arrayNumbers)
{
    for (int i  = 0; i < arrayNumbers.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arrayNumbers.GetLength(1); j++)
        {
            Console.Write(" {" + arrayNumbers[i, j] + "} ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
}

void FillArray (double [,] arrayNumbers)
{
    for (int i = 0; i < arrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumbers.GetLength(1); j++)
        {
            arrayNumbers[i, j] = new Random().Next(-9, 10);
        }    
    }
}


FillArray(arrayNumbers);
PrintArray (arrayNumbers);