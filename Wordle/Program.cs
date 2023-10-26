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

            var tracking = string.Empty;

            for (int i = 0; i < 6; i++)
            {
                string input = Console.ReadLine() ?? string.Empty;

                foreach (char c in input)
                {
                    int index;

                    if (wordOfTheDay.IndexOf(c) != -1)
                    {
                        tracking =
                        tracking = 
                    }
                }

                
                if (input == wordOfTheDay)
                {
                    Console.WriteLine("Success!!  Press any key to exit");
                    Console.Read();
                    return;
                }

                if (input.Length != 5)
                {
                    Console.WriteLine("Enter a 5 letter word please.");
                    i--;
                    continue;
                }
                    
                Console.WriteLine($"Incorrect!! you have {5 - i} attempts left");
                
            }


            Console.WriteLine("Game over!!  Press any key to exit");
            Console.Read();
        }

    }
}
