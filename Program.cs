class Program
{
    static void Main(string[] args)
    {
        var count = 15;

        string isMatch(int divisor, string word, int dividend) => dividend % divisor == 0 ? word : "";
        for (var i = 0; i <= count; i++)
        {
            if (i == 0) 
            {
                continue;
            }
            var fizzBuzz = isMatch(3, "Fizz", i) + isMatch(5, "Buzz", i);
            if (fizzBuzz.Length == 0)
            {
                System.Console.Write(i);
            }
            System.Console.WriteLine(fizzBuzz);
        }
    }
}
