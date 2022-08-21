//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

//Task 38: Specify an array of real numbers. 
//Find the difference between the maximum and minimum array elements.
//[3 7 22 2 78] -> 76

Console.WriteLine("How many numbers should I include in the array?");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[sizeArray];
randomNum(numbers);
void randomNum(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,10);
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
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}
Console.WriteLine($"The difference between the maximum and minimum array elements : {max - min}"); 

