//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] arrayOfCoordinate = new double[2, 2];
double[] pointIntersectionlines = new double[2];

void Coordinates()
{
  for (int i = 0; i < arrayOfCoordinate.GetLength(0); i++)
  {
    Console.Write($"Введите координаты точек прямой линии # {i+1} \n");
    for (int j = 0; j < arrayOfCoordinate.GetLength(1); j++)
    {
      if(j==0) Console.Write($"k{i+1} = ");
      else Console.Write($"b{i+1} = ");
      arrayOfCoordinate[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}
double[] Decision(double[,] Equationvariables)
{
  pointIntersectionlines[0] = (Equationvariables[1,1] - Equationvariables[0,1]) 
  / (Equationvariables[0,0] - Equationvariables[1,0]);
  pointIntersectionlines[1] = pointIntersectionlines[0] 
  * Equationvariables[0,0] + Equationvariables[0,1];
  return pointIntersectionlines;
}
void Line(double[,] Equationvariables)
{
  if (Equationvariables[0,0] == Equationvariables[1,0] && 
  Equationvariables[0,1] == Equationvariables[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (Equationvariables[0,0] == Equationvariables[1,1] &&
  Equationvariables[0,1] != Equationvariables[1,0]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(Equationvariables);
    Console.Write($"\nТочка пересечения прямых:({pointIntersectionlines[0]}, {pointIntersectionlines[1]})");
  }
}
Coordinates();
Line(arrayOfCoordinate);