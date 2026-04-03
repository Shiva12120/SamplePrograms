namespace programs;

public class Addsum
{
    static void Main(string[] args)
    {
        int number, sum = 0, r;

        Console.WriteLine("Enter a number for get the sum of digits:");


        number = int.Parse(Console.ReadLine()!);

        while (number > 0)
        {
            r = number % 10;

            sum = sum + r;

            number = number / 10;
        }

        Console.WriteLine($"Sum of digits for the given number: {sum}");

    }

}
