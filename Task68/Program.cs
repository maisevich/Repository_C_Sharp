/* 
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии,
когда даны два неотрицательных числа
*/

int firstNum = InputNumbers("Введите первое неотрицательное число: ");
int secondNum = InputNumbers("Введите второе неотрицательное число: ");

int functionAkkerman = Ack(firstNum, secondNum);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int firstNum, int secondNum)
{
  if (firstNum == 0) return secondNum + 1;
  else if (secondNum == 0) return Ack(firstNum - 1, 1);
  else return Ack(firstNum - 1, Ack(firstNum, secondNum - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}