using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Model
{
	public class Divisors
	{
		public static IList<Int32> DivisorsOfNumber(Int32 number)
		{
			List<Int32> ints = new List<Int32>();

			for (Int32 i = 1; i < number; i++)
			{
				if (number % i == 0)
				{
					ints.Add(i);
				}
			}

			return ints;
		}

		public static Boolean AreAmicablePairs(Int32 a, Int32 b)
		{
			if (a == b) return false;

			Int32 sum = DivisorsOfNumber(a).Sum();
			Int32 sum2 = DivisorsOfNumber(b).Sum();
			return sum == b && sum2 == a;
		}

	}
}