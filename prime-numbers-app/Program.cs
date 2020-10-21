using System;

namespace prime_numbers_app
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Prime numbers application: unit tests and code coverage demo");

			PrimeNumber pr = new PrimeNumber();

			for (int i = 2; i < 20; i++)
			{
				bool isPrime = pr.IsPrimeNumber(i);

				Console.WriteLine($"{i} - prime number: {isPrime}");
			}

			Console.WriteLine("Done");
		}
	}
}
