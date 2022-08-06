namespace Homework
{
    // Задача 6: Найдите четное число

    class Program
    {
        static void Main (string[]args)
        {
            Console.WriteLine ("Введите число");

            int a;

            a = int.Parse(Console.ReadLine());

            int temp = a % 2;
            
            bool result = temp ==0;

            if(result)
            {
            Console.WriteLine ("Четное число");
            }
            else
            {
                Console.WriteLine("Нечетное число");
            }
                     
        }    

    }

} 

