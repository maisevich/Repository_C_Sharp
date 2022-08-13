Console.Write("Введите любое число для того, чтобы программа вовзела в куб все числа от 0 до введенного Вами числа : ");
int theNumberInTheCube = Convert.ToInt32(Console.ReadLine());
void Cube(int[] theNumberInTheCube)
{
  int counter = 0;
  int length = theNumberInTheCube.Length;
  while (counter <  length)
  {
    theNumberInTheCube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}
void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  while(index < count)
  {
    Console.Write(coll[index]+ " ");
    index++;
  }
} 
int[] array = new int[theNumberInTheCube+1];
Cube(array);
PrintArry(array);