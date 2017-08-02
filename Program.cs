using System;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			int count = 0;
			if (args.Length < 1)
			{
				return;
			}
			if (!int.TryParse(args[0], out count))
			{
				if (args.Length < 2)
				{
					return;
				}
				if (!int.TryParse(args[1], out count))
				{
					return;
				}
			}
			string str;
			bool isSet;
			for (var i = 1; i <= count; i++)
			{
				str = string.Empty;
				isSet = false;
				if (i % 3 == 0)
				{
					str = "Fizz";
					isSet = true;
				}
				if (i % 5 == 0)
				{
					str += "Buzz";
					isSet = true;
				}
				if (!isSet)
				{
					Console.WriteLine(i);
				}
				else
				{   
					Console.WriteLine(str);
				}
			}
		}
	}
}
