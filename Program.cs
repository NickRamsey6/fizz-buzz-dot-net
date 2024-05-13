// I removed the System library because looks like later versions of DotNet support top-level functions so I dont need System to write to the console.
public class Program
{
    
    public static void Main()
    {
        // With simple console/terminal programs I like to include a little interactivity for the user in the form of console inputs. Adds a little flexibility to the program.
        Console.WriteLine("Please enter the number you want to count FizzBuzz to (Must be an integer):");
        // I like the explicit type setting used by C# just like Java. The exception thrown here for non-int values is very simple and intuitive. 
        int countToNum = Convert.ToInt32(Console.ReadLine());
        // We will start with 1 and count up by 1 up to and including the user's number.
        for (int i = 1; i <= countToNum; i++)
        {
            // We check for the AND conditional first because otherwise we will never hit it with this setup. If we set divisible by 3 to "Fizz" first then this conditional would be skipped.
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