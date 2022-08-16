//namespace Lessons
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("I know why you wanna hate me");
//            int count = 0;
//            int limit = int.Parse(Console.ReadLine()); 
//
//            while (count < limit)
//            {
//                count++;
//                Console.WriteLine(count);
//            }
//            
//
//        }
//    }
//}

//namespace Lessons
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int limit = int.Parse(Console.ReadLine());
//            for (int i = 0; i < limit; i++)
//            {
//                
//                if (i%2==0)
//                {
//                    Console.WriteLine("Четное число № ");
//                    
//                }                      
//                else
//                {
//                    Console.WriteLine("Нечетное число № ");
//                    
//                }             
//            }
//        }
//    }
//}

//namespace Lessons
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 0; i <=10; i++)
//            {
//                for (int j = 0; j <=10; j++)
//                {
//                    Console.WriteLine($"{i} x {j} = {i*j}");        
//                      
//                }             
//            Console.WriteLine();
//            }
//
//        }
//    }
//}


//Work in text 

string text = " Привет, я даже нн скучаю ";
//string Replace(string text, char oldValue, char newValue);
static extern string Replace (string text, char oldChar, char newChar);
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
//{
//   string result = String.Empty;
//    int length = text.Length;
//    for (int i = 0; i < length; i++)
//    {
//        if (text[1] == oldChar) result = result + $"{newChar}";
//        else result = result + $"{text[1]}";        
//    }
//    return result;
//}
//string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);