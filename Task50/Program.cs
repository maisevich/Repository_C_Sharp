//Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве

Console.WriteLine();

Console.WriteLine("Введите строку элемента, который хотите выбрать - ");
int lineNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите столбец элемента, который хотите выбрать - ");
int columnNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[,] coordinatesNumber = new double[lineNumber, columnNumber];

int stringsArray = new Random().Next(3, 9);
int columnsArray = new Random().Next(3, 9);

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
            arrayNumbers[i, j] = new Random().Next(1, 9);
        }    
    }
}

void DisplayArray (double[,] coordinatesNumber)
{
    if (lineNumber <= stringsArray && columnNumber <= columnsArray)
    {
        Console.WriteLine();
        Console.WriteLine("Под теми координатами, которые Вы ввели, в массиве находится число:");
        Console.Write("{" + arrayNumbers[lineNumber, columnNumber] + "}");
        Console.WriteLine();
    }
    else
    {
       Console.WriteLine();
       Console.WriteLine("Число с такими координатами в массиве отсутствует"); 
       Console.WriteLine();
    }
}

FillArray(arrayNumbers);
PrintArray (arrayNumbers);
DisplayArray (coordinatesNumber);