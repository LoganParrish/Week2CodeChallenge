using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }
            
            LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.");
            Console.ReadKey();

        }
        static void FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        static void LetterCounter(char letter, string inString)
        {

            Console.WriteLine("\n" + inString);

            int lowerCount = 0;
            int upperCount = 0;
            int totalCount = 0;

            foreach (char i in inString)
            {
                

                if (i.ToString() == letter.ToString().ToLower())
                {
                    lowerCount++;
                    totalCount++;
                }
                else if (i.ToString() == letter.ToString().ToUpper())
                {
                    upperCount++;
                    totalCount++;
                }
            }
            Console.WriteLine("\n\nNumber of lowercase letters found : " + lowerCount);
            Console.WriteLine("Number of uppercase letters found : " + upperCount);
            Console.WriteLine("\nTotal number of letters found : " + totalCount + "\n\n\n");
        }
    }
}
