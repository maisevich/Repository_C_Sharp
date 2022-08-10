Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("Это выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("Такого дня недели не существует");
  }
  else Console.WriteLine("Это рабочий день");
}

CheckingTheDayOfTheWeek(dayNumber);
