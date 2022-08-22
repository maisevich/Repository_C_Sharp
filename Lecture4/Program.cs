// Двухмерные массивы
//тип строк, количество
//string[,] table = new string[2, 5];
// строки исчисляются как и в массивах - с 06
// String.Empty
//table[1, 1] = "слово";
//for (int rows  = 0; rows < 2; rows++)
//{
//    for (int columns = 0; columns < 5; columns++)
//    {
//        Console.WriteLine($"-{table[rows, columns]}-");
//    }
//}
      
//matrix[1, 1] = 4;
//void PrintArray (int[,] matr)
//{
//    for (int rows  = 0; rows < matr.GetLength(0); rows++)
//    {
//        for (int columns = 0; columns < matr.GetLength(1); columns++)
//        {
//            Console.Write($"{matr[rows, columns]} ");
//        }
//        Console.WriteLine();
//    }
//}
//void FillArray (int [,] matr)
//{
//    for (int rows = 0; rows < matr.GetLength(0); rows++)
//    {
//        for (int columns = 0; columns < matr.GetLength(1); columns++)
//        {
//            matr[rows, columns] = new Random().Next(1, 10);
//        }    
//    }
//}
                    //строки
//int[,] matrix = new int[4,4];
                          //столбцы

//PrintArray(matrix);
//FillArray(matrix);
//Console.WriteLine();
//PrintArray(matrix);

//void PrintArray (int[,] matr)
//{
//    for (int rows  = 0; rows < matr.GetLength(0); rows++)
//   {
//        for (int columns = 0; columns < matr.GetLength(1); columns++)
//        {
//            Console.Write($"{matr[rows, columns]} ");
//        }
//        Console.WriteLine();
//    }
//}
// Задача следующая по "отлично"
//int[,] pic   = new int[5, 5];

//void PrintImage (int[,] image)
//{
//    for (int rows  = 0; rows < image.GetLength(0); rows++)
//    {
//        for (int columns = 0; columns < image.GetLength(1); columns++)
//        {
//            Console.Write($"{image[rows, columns]} ");
//            if (image[rows, columns] == 0) Console.Write($"+");
//            else Console.Write($"1");
//        }
//        Console.WriteLine();
//    }
//}
//void FillImage (int row, int columns)
//{
//   if(pic[row, columns] == 0)
//    {
//       pic[row, columns] = 1; 
//       FillImage(row-1, columns);
//       FillImage(row, columns-1);
//       FillImage(row+1, columns);
//       FillImage(row, columns+1);
//    }

//}
//PrintImage(pic);
//FillImage(2, 2);
//PrintImage(pic);

//double Factorial (int n)
//{
//    if (n == 1) return 1;
//    else return n * Factorial(n -1);
//}
//for (int i = 1; i < 40; i++)
//{
//    Console.WriteLine($"{i}!= {Factorial(i)}");
//}

double Fibonacci (int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);  
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"f{i}! = {Fibonacci(i)}");
}