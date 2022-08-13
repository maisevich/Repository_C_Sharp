Console.Write("What is your name?");
string name = Convert.ToString(Console.ReadLine());
var date = DateTime.Now;
Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
