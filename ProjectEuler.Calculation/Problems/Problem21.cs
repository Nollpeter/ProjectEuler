using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Model;

namespace ProjectEuler.Calculation.Problems
{
	public class Problem21 : IProblem
	{
		#region Implementation of IProblem

		public void Run()
		{

			HashSet<Int32> numbers = new HashSet<Int32>();

			for (Int32 i = 0; i < 10000; i++)
			{
				IList<Int32> divisorsOfNumber = Divisors.DivisorsOfNumber(i);
				Int32 b = divisorsOfNumber.Sum();
				Boolean areAmicablePairs = Divisors.AreAmicablePairs(i, b);

				if (areAmicablePairs)
				{
					numbers.Add(i);
					numbers.Add(b);
				}


			}

			Int32 sum = numbers.Sum();

			Console.WriteLine(sum);
		}

		#endregion
	}
}