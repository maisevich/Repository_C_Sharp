Console.WriteLine("Hello World! Homework task number 19");
{
    Console.Write("Enter a five-digit  number  ");
    int newNumber = Convert.ToInt32(Console.ReadLine());
    {
        if (newNumber >= 10000 & newNumber <= 99999)
        {
            string newNumberText = Convert.ToString(newNumber);
            if (newNumberText[0] == newNumberText[4] & newNumberText[1] == newNumberText[3])
            {
                Console.WriteLine("The number you entered is a palindrome!");
            }
            else
            {
                Console.WriteLine("The number you entered is NOT a palindrome!");
            }
        }
        else if (newNumber < 10000) 
        {
            Console.WriteLine("You entered a number with fewer than five digits! Try again");
        }
        else Console.WriteLine("You entered a number with the number of digits greater than five! Try again");
    }
}

