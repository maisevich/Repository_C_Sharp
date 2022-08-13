//Console.WriteLine("Task number one");
// Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа. 
// А программа сранивает два введенных числа и выводит на консоль результат сравнения 
//(два числа равны, первое число больше второго или первое число меньше второго).
//Console.Write("Введите первое число ");
//int numOne = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число ");
//int numTwo = Convert.ToInt32(Console.ReadLine());
//    if (numOne > numTwo)
//    {
//        Console.WriteLine("Наибольшее число -  второе : " + numOne);
//    }
//    else if (numOne < numTwo)
//    {
//        Console.WriteLine("Наимбольшее число - второе : " + numTwo);
//    } 
//    else
//    {
//        Console.WriteLine("Вы ввели два одинаковых числа");
//    }


//Console.Write("Введите Ваше число ");
//int num = Convert.ToInt32(Console.ReadLine());
//    if (num > 5 & num < 10)
//    {
//        Console.WriteLine("Введденное Вами число меньше пяти и больше десяти");
//    }
//    else 
//    {
//        Console.WriteLine("Неизвестное число ");
//    } 

//using System;

//namespace HelloApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Введите число ");
//            int numOne = Convert.ToInt32(Console.ReadLine());
//           
//            if (numOne == 5 || numOne == 10)
//            {
//                Console.WriteLine("Число либо равно 5. либо равно 10");
//            }
//            else
//            { 
//                Console.WriteLine("Неизвестное число");
//            }
//        }   
//    }
//}

//using System;
//
//namespace HelloApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Введите сумму Вашего вклада: ");
//            double sum = Convert.ToDouble(Console.ReadLine());
//            
//            if (sum < 100)
//            {
//                sum += sum * 0.05;        
//            }
//            else if (sum >= 100 && sum < 200)
//            { 
//                sum += sum * 0.07;
//            }
//            else
//            {
//                sum += sum * 0.1;
//            }
//            Console.WriteLine($"Сумма вклада после начисления процентов: {sum}");
//            double sum2 = sum + 15;
//            Console.WriteLine("Сумма вклада с бонусами банкаж: "+ sum2);
//        }   
//    }
//}

//using System;
//
//namespace HelloApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Введите сумму Вашего вклада: ");
//            double sum = Convert.ToDouble(Console.ReadLine());
//            double percent = 0;
//            if (sum < 100)
//            {
//                percent = 0.05;        
//            }
//            else if (sum >= 100 && sum < 200)
//            { 
///                percent = 0.07;
//            }
//            else
//           {
//                percent = 0.1;
//            }
//            sum += sum * percent + 15;
//            Console.WriteLine($"Сумма вклада после начисления процентов: {sum}");
//            
//        }   
//    }
//}

//using System;
 
//namespace HelloApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите номер операции: ");
//            Console.WriteLine("1. Вычитание");
//            Console.WriteLine("2. Сложение");
//            Console.WriteLine("3. Умножение");
//            int operation = Convert.ToInt32(Console.ReadLine());
//            if (operation == 1)
//            {
//                Console.WriteLine("Вычитание");
//            }
//            else if (operation == 2)
//            {
//                Console.WriteLine("Сложение");
//           }
//            else if (operation == 3)
//            {
//               Console.WriteLine("Умножение");
//            }
//            else
//            {
//                Console.WriteLine("Неизвестная операция");
//            }
//           
//        }
//    }
//}

//using System;
 
//namespace HelloApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите первое число: ");
//            double num1 = Convert.ToDouble(Console.ReadLine());
//
//            Console.WriteLine("Введите второе число: ");
//           double num2 = Convert.ToDouble(Console.ReadLine());
//
//            Console.WriteLine("Введите номер операции, которую необходимо выполнить с числами: ");
//            Console.WriteLine("1. Вычитание");
//            Console.WriteLine("2. Сложение");
//            Console.WriteLine("3. Умножение");
//            Console.WriteLine("4. Деление");
// 
//            int operation = Convert.ToInt32(Console.ReadLine());
//            switch (operation)
//            {
//                case 1:
//                    Console.WriteLine("Вы выбрали операцию вычитания");
//                    Console.WriteLine(num1 - num2);
//                    break;
//                case 2:
//                    Console.WriteLine("Вы выбрали операцию вычитания сложения");
//                    Console.WriteLine(num1 + num2);
//                    break;
//                case 3:
//                   Console.WriteLine("Вы выбрали операцию вычитания умножения");
//                    Console.WriteLine(num1 * num2);
//                    break;
//                case 4:
//                    Console.WriteLine("Вы выбрали операцию вычитания деления");
//                    Console.WriteLine(num1 / num2);
//                    break;
//                default:
//                    Console.WriteLine("Неизвестная операция");
//                    break;
//            }
//            Console.ReadKey();
//        }
//    }
//}

using System;
 
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine("Введите номер операции: 1.Сложение  2.Вычитание  3.Умножение");
 
            int operation = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (operation)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Результат операции {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Результат операции {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Результат операции {result}");
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }
            Console.ReadKey();
        }
    }
}