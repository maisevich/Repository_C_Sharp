//.Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


int stringsArray = new Random().Next(2, 3);
int columnsArray = new Random().Next(2, 3);

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
            arrayNumbers[i, j] = new Random().Next(2, 4);
        }    
    }
}

void DisplayArray (double[,] arrayNumbers)
{
    double sum = 0;
    double middle = 0;
    Console.Write($"\nCреднее арифметическое знсчение чисел столбца:\n");
        for (int i = 0; i < arrayNumbers.GetLength(0); i++)
        {
            for (int j = 0; j < arrayNumbers.GetLength(1); j++)
            {
                sum += arrayNumbers[i, j];
                middle = Math.Round(sum / i, 1);
                Console.WriteLine($"№ {j+1} = {middle}");
            }
        }
}

FillArray(arrayNumbers);
PrintArray (arrayNumbers);
DisplayArray (arrayNumbers);