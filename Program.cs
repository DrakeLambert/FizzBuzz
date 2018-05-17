using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 15;

			string isMatch(int check, string word, int number) => number % check == 0 ? word : "";
            for (var i = 1; i <= count; i++)
            {
                var fizzBuzz = isMatch(3, "Fizz", i) + isMatch(5, "Buzz", i);
                if (fizzBuzz.Length == 0)
                {
                    Console.Write(i);
                }
                Console.WriteLine(fizzBuzz);
            }
        }
    }
}