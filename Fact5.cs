namespace programs;

public class Fact5
{
    public static void Main(string[] args)
    {
        int number, fact = 1,i;

        Console.WriteLine("Enter a number for factorial:");

        number = int.Parse(Console.ReadLine()!);

        for (i = 1; i <=number; i++)
        {
            fact = fact * i;
            
        }

        Console.WriteLine($"Factorial of a given number is :{fact}");
    }

}
