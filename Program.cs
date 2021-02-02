using System;
using System.Collections.Generic;

namespace exercise_47
{
    class Program
    {
        private static string response;

        static void Main(string[] args)
        {
            
            var result = new string[500];
            var index = 0;

            do
            {
                Console.WriteLine("Please enter a word: ");
                result [index] = Console.ReadLine();
                index++;
            } while (tryAgain());

            PrintOutput(result);
            Console.ReadLine();
        }
            static bool tryAgain()
            {
                Console.Write("Would you like to try again? ");
                var response = Console.ReadLine();
                return response.Equals("y", StringComparison.OrdinalIgnoreCase);
            }

            static void PrintOutput(string[] words)
            {
                foreach (var word in words)
                {
                    if (word == null)
                    {
                        break;
                    }
                
                Console.Write($"{word} ");
                
                }

            }
            
    }   
}
