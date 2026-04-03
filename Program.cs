//Palindrome or not


using System;
class Program
{
    public void Main(string[] args)
    {
        int number, r, temp, sum = 0;

        Console.WriteLine("Enter a number:");
        number= int.Parse(Console.ReadLine()!);
        temp = number;


        while (number > 0)
        {
            r = number % 10;

            sum = sum * 10 + r;

            number = number / 10;


        }

        if (temp == sum)
        {
            Console.WriteLine("Given number is a palindrome");
        }

        else

        {
            Console.WriteLine("Given number is not a palindrome");

        }
    }

}





