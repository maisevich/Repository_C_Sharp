//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//Task 36: Set a one-dimensional array filled with random numbers. 
//Find the sum of the elements standing in odd positions.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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
int sum = 0;
for (int a = 0; a < numbers.Length; a+=2)
    sum = sum + numbers[a]; 

Console.WriteLine($"The sum of the numbers standing in odd positions : {sum}"); 
