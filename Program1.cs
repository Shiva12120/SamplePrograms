using System;

public class Program1
{
    static void Main(string[] args)
    {
        int number, i = 1, count = 0;

        Console.WriteLine("Enter a number to check Prime or Not:");

        number = int.Parse(Console.ReadLine());

        for (i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        if (count == 2)
        {
            Console.WriteLine("Given number is prime Number");
        }
        else
        {
            Console.WriteLine("Given number is not a prime number");
        }

        Console.ReadLine();

    }

}