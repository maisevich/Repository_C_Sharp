
// Задача 41. Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write($"Введите, пожалуйста, количество чисел для Вашего массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] NumArray = new int[a];

void Numbers(int a)
{
for (int i = 0; i < a; i++)
  {
    Console.Write($"Введите число массива № {i+1} : ");
    NumArray[i] = Convert.ToInt32(Console.ReadLine());
  }
}
int NumConrtast(int[] NumArray)
{
  int count = 0;
  for (int i = 0; i < NumArray.Length; i++)
  {
    if(NumArray[i] > 0 ) count += 1; 
  }
  return count;
}
Numbers(a);
Console.WriteLine($"Число введенных Вами чисел больше нуля составило - {NumConrtast(NumArray)}");