using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get word of the day
            string wordOfTheDay = string.Empty;
            using (var reader = new StreamReader("dictionary.txt"))
            {
                for (int i = 0; i < DateTime.Today.Day; i++)
                {
                    wordOfTheDay = reader.ReadLine();
                }
            }

            Console.WriteLine("Welcome to wordle!!");
            Console.WriteLine("Enter a 5 letter word > you have 6 attempts!!");

            var tracking = new ConsoleColor[5];


            //check for 6 attempts
            for (int i = 0; i < 6; i++)
            {
                string input = Console.ReadLine() ?? string.Empty;
                int inputIndex;

                // analyse input string
                foreach (char c in input)
                {
                    inputIndex = input.IndexOf(c);

                    if (wordOfTheDay.IndexOf(c) != -1)
                    {
                        if (inputIndex == wordOfTheDay.IndexOf(c))
                        {
                            tracking[inputIndex] = ConsoleColor.Green;
                            continue;
                        }

                        tracking[inputIndex] = ConsoleColor.Yellow;
                        continue;
                    }

                    tracking[inputIndex] = ConsoleColor.White;
                }



                if (input == wordOfTheDay)
                {
                    Console.WriteLine("Success!!  Press any key to exit");
                    Console.Read();
                    return;
                }

                if (input.Length != 5 || input == ConsoleKey.Enter.ToString())
                {
                    Console.WriteLine("Enter a 5 letter word please.");
                    i--;
                    continue;
                }

                Console.WriteLine("-----");

                inputIndex = 0;
                tracking.ToList().ForEach(x =>
                    {
                        Console.ForegroundColor = tracking[inputIndex];
                        Console.Write(input[inputIndex++]);
                    }
                );

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Incorrect!! you have {5 - i} attempts left");

            }


            Console.WriteLine("Game over!!  Press any key to exit");
            Console.Read();
        }

    }
}
