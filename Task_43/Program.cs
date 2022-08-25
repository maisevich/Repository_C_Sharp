//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] Num1 = new double[2, 2];
double[] Num2 = new double[2];

void Coordin()
{
  for (int i = 0; i < Num1.GetLength(0); i++)
  {
    Console.Write($"Введите данные для прямой линии {i+1} \n");
    for (int j = 0; j < Num1.GetLength(1); j++)
    {
      if(j==0) Console.Write($"k{i+1} = ");
      else Console.Write($"b{i+1} = ");
      Num1[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}
double[] Decision(double[,] LineCoeff)
{
  Num2[0] = (LineCoeff[1,1] - LineCoeff[0,1]) / (LineCoeff[0,0] - LineCoeff[1,0]);
  Num2[1] = Num2[0] * LineCoeff[0,0] + LineCoeff[0,1];
  return Num2;
}

void Line(double[,] LineCoef)
{
  if (LineCoef[0,0] == LineCoef[1,0] && LineCoef[0,1] == LineCoef[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (LineCoef[0,0] == LineCoef[1,0] && LineCoef[0,1] != LineCoef[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(LineCoef);
    Console.Write($"\nТочка пересечения прямых: ({Num2[0]}, {Num2[1]})");
  }
}

Coordin();
Line(Num1);