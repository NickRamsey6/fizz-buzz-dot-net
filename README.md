# FizzBuzz in C# with DotNet

## See "Program.cs" file for FizzBuzz code

## How to run program
```
    cd <into directory you want to save this project>
    git clone https://github.com/NickRamsey6/fizz-buzz-dot-net.git
    cd fizzbuzz-dot-net
    dot net run
```
## Assignment
Using C# code with the .NET framework, write a sample FizzBuzz program. The FizzBuzz program will count up by 1 and for each number divisible by 3, the program will print "Fizz". For each number divisible by 5, the program will print "Buzz" and for numbers divisible by 3 and 5, the program will print "FizzBuzz".

## Process
With minimal prior C# experience, I started this project by researching simple ways to setup a C# program with .NET. I downloaded the .NET SDK and then used `dotnet new console -o` in the terminal to create the project. I then used `dotnet run` in the terminal to print "Hello, World!" to the console using the boiler plate code that was created with the project. This was useful as printing simple messages to the console is a key component to the assignment. I then researched C# syntax for looping and if/else if/else conditionals. The syntax is pretty simple and reminded me a lot of Java with the explicit type casting, which I find very useful when working with legacy code.

## Decisions
Typically, I like to write code that follows the path of the assignment as it would be communicated. When someone explains the FizzBuzz problem they will often start with: "The program will print 'Fizz' for each number divisible by 3." So, typically, that is where I would want my code logic to start as well. But in this example, I chose to start with the "FizzBuzz" AND conditional for 3 and 5 because if the program first evaluates a number as divisible by 3, then that condition is met and no further evaluation or conditional is checked. With that idea in mind, I decided to work backwards and move from the "FizzBuzz" AND conditional to the "Buzz" divisible by 5 check, then the "Fizz" divisible by 3 check and finally the else conditional for the rest of the numbers.

Whenever I write programs that the user will operate out of the terminal, I prefer to allow for user input instead of hardcoding variables. With this program, I chose to allow the user to set the number they want FizzBuzz to count to. I realize this can open up the program to unexpected errors, but with C#'s explicit type casting I am able to convert the inputted value to an integer (if it meets the requirements of an integer) and non integer values inputted will throw an exception. Best practices probably dictated exception handling here, maybe I should have the program re-prompt the user for another value if they do not enter an integer the first time. But for the scope of this project, I was satisfied with how readable the exception message was that I am comfortable having the user re-run the program, now knowing an integer value is required.

## Conclusion
Overall, this was an enjoyable first adventure in C# with the .NET framework! Seeing C# syntax instantly brought me back to my old Java experience from 5 years ago and reminded me what I enjoyed about Java (Explicit type casting, well organized classes and functions, etc.). I am sure there are plenty of ways this code can be better optimized or run faster, but for now I just wanted to research the basics. I look forward to any feedback or further discussions here.