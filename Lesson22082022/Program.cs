int programm;
Boolean begin = true;
int[] arrayInt = { };
while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("   1.\t Пользователь вводит с клавиатуры M чисел. \n\t Результат = сколько чисел больше 0 ввёл пользователь. \n");
    Console.WriteLine("   2.\t Программа, которая найдёт точку пересечения двух прямых.");

    programm = Convert.ToInt32(Console.ReadLine());

    switch (programm)
    {
        case 1:
            CaseProgramm1();
            break;
        case 2:
            CaseProgramm2();
            break;
        default:
            begin = false;
            break;
    }
}

//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
void CaseProgramm1()
{
    Console.WriteLine("Введите любые числа разделённые любым знаком");
    int[] array = Array.ConvertAll
    (
        FilterStringOutDigitals(Console.ReadLine()).Split(" "),
        int.Parse
    );

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine("Введено положительных чисел: " + count);
}

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
void CaseProgramm2()
{
    double enterNumberK1, enterNumberB1;
    double enterNumberK2, enterNumberB2;
    double resultCoordinateX, resultCoordinateY;

    Console.WriteLine("Укажите запрошенные переменные для двух прямыx заданых уравнением:");
    Console.WriteLine("y = k * x + b");

    Console.Write("k1 = ");
    enterNumberK1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b1 = ");
    enterNumberB1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("k2 = ");
    enterNumberK2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b2 = ");
    enterNumberB2 = Convert.ToDouble(Console.ReadLine());

if (enterNumberK1 != enterNumberK2)
{
    resultCoordinateX = (enterNumberB2 - enterNumberB1) / (enterNumberK1 - enterNumberK2);
    resultCoordinateY = enterNumberK2 * resultCoordinateX + enterNumberB2;

    Console.WriteLine("Координаты точки пересечения:");
    Console.WriteLine($"X = {resultCoordinateX} ; Y = {resultCoordinateY}");
}
else if (enterNumberB1 == enterNumberB2) Console.WriteLine("Прямые совпадают");
else Console.WriteLine("Прямые параллельны");

    // resultCoordinateY = K2 * resultCoordinateX + B2
    // K1 * resultCoordinateX + B1 = K2 * resultCoordinateX + B2
    // K1 * resultCoordinateX - K2 * resultCoordinateX = B2 - B1
    // (K1 - K2) * resultCoordinateX = B2 - B1
    // resultCoordinateX = (B2 - B1) / (K1 - K2)

}

// Убирает из строки все символы кроме чисел и заменяет их пробелом.
string FilterStringOutDigitals(string inputString)
{
    int tempParseNum;
    bool checkDounleChar = true;

    for (int i = 0; i < inputString.Length; i++) // На выходе должны получить строку где все НЕ цифры заменены пробелами
    {
        if (int.TryParse(Convert.ToString(inputString[i]), out tempParseNum)
        || inputString[i] == '-' && int.TryParse(Convert.ToString(inputString[i + 1]), out tempParseNum))
        //первым условием проверяем временную строку на числа 
        //вторым через || считаем числом '-' и оставляем в строке
        //третьим через && фильтруем ошибки ввода знака '-' не перед числом
        //осталась ошибка OutOfRange от inputString[i+1] в случае если знак '-' идёт последним
        {
            checkDounleChar = false;
        }
        else //Заменяем символы пробелом. 
             //Можно попробовать Replace, но я побоялся что она будет сканировать всю строку для каждого уникального символа
        {
            if (checkDounleChar) // удаляем двойные символы
            {
                inputString = inputString.Remove(i, 1);
                checkDounleChar = true;
                i--;
            }
            else
            {
                inputString = inputString.Remove(i, 1);
                inputString = inputString.Insert(i, " ");
                checkDounleChar = true;
            }
        }
    }

    if (checkDounleChar) inputString = inputString.Remove(inputString.Length - 1, 1); // удаляем последний символ если не цифра
    return inputString;
}
