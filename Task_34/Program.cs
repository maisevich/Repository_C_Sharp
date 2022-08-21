//Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//Task 34: Specify an array filled with random positive three-digit numbers. 
//Write a program that will show the number of even numbers in the array.

Console.WriteLine("How many numbers should I include in the array?");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[sizeArray];
randomNum(numbers);
void randomNum(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
Console.WriteLine("Array : ");
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
Console.WriteLine($"Even numbers in the array: {count}");