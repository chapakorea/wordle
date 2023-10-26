// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Welcome to wordle!!");
Console.WriteLine("Enter a 5 letter word > you have 6 attempts!!");


var input = string.Empty;

var attempts = 0;

for (int i = 0; i < 6; i++)
{
    while (input.Length < 5)
    {
        input = Console.ReadLine() ?? string.Empty;
    }
}


if (input == "12345")
{
    Console.WriteLine("Success!!");

}

Console.WriteLine("Game over!!");

Console.ReadLine();