namespace Homework
{
    // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное.

    class Program
    {
        static void Main (string[]args)
        {
            Console.WriteLine ("Введите число a ");

            int a;

            a = int.Parse(Console.ReadLine());

            Console.WriteLine ("Введите число b ");

            int b;

            b = int.Parse(Console.ReadLine());

            if(a > b)
            {
            Console.WriteLine ("Максимальное число - " + a);
            }
            else
            {
                Console.WriteLine("Максимальное число - " + b);
            }
                     
        }    

    }

} 


