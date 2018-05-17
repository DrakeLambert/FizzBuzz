using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 15;

            Func<int, string> isFizz = i => i % 3 == 0 ? "Fizz" : "";

            Func<int, string> isBuzz = i => i % 5 == 0 ? "Buzz" : "";

            var fizzBuzz = "";
            for (var i = 1; i <= count; i++)
            {
                fizzBuzz = isFizz(i) + isBuzz(i);
                if (fizzBuzz.Length == 0)
                {
                    Console.Write(i);
                }
                Console.WriteLine(fizzBuzz);
            }
        }
    }
}