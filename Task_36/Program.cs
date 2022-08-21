//Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Какое количество чисел включить в массив?");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[sizeArray];
randomNum(numbers);
Console.WriteLine("Массив : ");
PrintArray(numbers);
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + ", ");
    }
    Console.Write("]");
    Console.WriteLine();
}
int count = 0;
for (int a = 0; a < numbers.Length; a++)
if (numbers[a] % 2 == 0)
count++;
Console.WriteLine($"Четных чисел в массиве: {count}");
void randomNum(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
