/* 
Задача: Написать программу, которая из имеющегося массива строк
 формирует новый массив из строк, длина которых меньше, 
 либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.WriteLine("Заданный массив строк: ");

string[] stringArray = { "Hello", "212", "Wed", ":))", "GB" };

for (int i = 0; i < stringArray.Length; i++)
    if (stringArray[i].Length <= 3)
    {
        Console.WriteLine(stringArray[i]);
    }

    //Console.WriteLine("Element[{0}] = {1}", i, stringArray[i]);
    //Console.ReadKey();

//Console.WriteLine("The length of '{0}' is {1}", stringArray[0], stringArray[0].Length);


/*
Console.Write(stringArray[0] + ", ");
Console.Write(stringArray[1] + ", ");
Console.Write(stringArray[2] + ", ");
Console.Write(stringArray[3] + ", ");
Console.Write(stringArray[4] + ", ");
*/
 


