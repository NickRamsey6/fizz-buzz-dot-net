
public class Program
{
    
    public static void Main()
    {
        Console.WriteLine("Please enter the number you want to count FizzBuzz to:");
        int countToNum = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= countToNum; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else
                Console.WriteLine(i);
        }
    }
}