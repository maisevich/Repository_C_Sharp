// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int numbA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numbB = Convert.ToInt32(Console.ReadLine());
int expon(int numA, int numB)
{
  int result = 1;
  for(int i=1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}
int exp = expon(numbA, numbB);
Console.WriteLine("Ответ: " + exp);
