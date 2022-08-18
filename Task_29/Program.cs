// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] numbers = new int[8];
Console.Write("[");
for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 1000);
    Console.Write(Method (i) + ", ");
  }
Console.Write("]");
int Method (int a)
{
    return numbers[a];
}
