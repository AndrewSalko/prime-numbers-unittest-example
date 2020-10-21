using System;
using System.Collections.Generic;
using System.Text;

namespace prime_numbers_app
{
	/// <summary>
	/// Prime number detection. See wiki about algorithm's details:
	/// https://en.wikipedia.org/wiki/Trial_division
	/// </summary>
	class PrimeNumber
	{
		public PrimeNumber()
		{
		}

		public bool IsPrimeNumber(int number)
		{
			if (number <= 0)
				throw new ArgumentException("Must be greater than zero", nameof(number));

			if (number == 1)
				return false;   //not a prime number

			int i = 2;
			while (i * i <= number)
			{
				if (number % i == 0)
				{
					return false;
				}

				i++;
			}

			return true;
		}

	}
}
