
Console.WriteLine();

Console.Write("Задача 52. Задайте двумерный массив из целых чисел.");
Console.Write("Программа найдет среднее арифметическое элементов в каждом столбце массива");

Console.WriteLine();

Console.WriteLine("Введите количество строк для массива чисел :");
int stringArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите количество столбцов для массива чисел :");
int columnArray = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [stringArray, columnArray];
double [] sumMiddle = new double [columnArray];
Random ran = new Random();

for (int i=0; i<stringArray; i++)
{
    for(int j=0; j<columnArray; j++)
    {
        array[i, j] = ran.Next(0, 100);

        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i=0; i<columnArray; i++)
{
    for(int j=0; j<stringArray; j++)
    {
        sumMiddle[i] += array[j, i];
    }
}

Console.WriteLine();

Console.Write("Среднее арифметическое каждого столбца: ");
for (int i=0; i<columnArray; i++)
{
    Console.Write(sumMiddle[i] / stringArray + "; ");
}
Console.WriteLine();