Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.Write("Введите натуральное число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
  Console.WriteLine("Третья цифра введенного Вами числа : " + anyNumberText[2]);
}
else 
{
  Console.WriteLine("Третьей цифры в введенном Вами числе нет");
}
