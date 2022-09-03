/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите поочережно числа М и N");
int firstNum = Convert.ToInt32(Console.ReadLine());
int lastNum = Convert.ToInt32(Console.ReadLine());
int count = lastNum - firstNum + 1;
Console.Write("Сумма натуральных элементов в промежутке от M до N = "); 
Console.Write((firstNum + lastNum) * count/2);