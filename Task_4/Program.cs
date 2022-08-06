namespace Homework
{
    // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное.

    class Program
    {
        static void Main (string[]args)
        {
            Console.WriteLine ("Введите числа a, b, c.");

            int a;

            a = int.Parse(Console.ReadLine());

            int b;

            b = int.Parse(Console.ReadLine());

            int c;

            c = int.Parse(Console.ReadLine());
            
            if(a >= b && a >= c)
            {
            Console.WriteLine ("Максимальное число - " + a);
            }
            else if (b >= a && b >= c)  
            {
            Console.WriteLine("Максимальное число - " + b);
            }
            else if (c >= a && c >= b)  
            {
            Console.WriteLine("Максимальное число - " + c);
            }        
        }    

    }

} 



