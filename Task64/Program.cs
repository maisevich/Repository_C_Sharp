/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> 5, 4, 3, 2, 1
*/

Console.WriteLine("Введите любое число больше единицы");
int lastNumber = Convert.ToInt32(Console.ReadLine());
int count = 2;

PrintNumber(lastNumber, count);
Console.Write(1);

void PrintNumber(int lastNumber, int count)
{
  if (count > lastNumber) return;
  PrintNumber(lastNumber, count + 1);
  Console.Write(count + ", ");
}
