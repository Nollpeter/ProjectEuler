using System;
using System.Linq;
using System.Numerics;
using ProjectEuler.Model;

namespace ProjectEuler.Calculation.Problems
{
	public class Problem20 : IProblem
	{
		#region Implementation of IProblem

		public void Run()
		{
			BigInteger bigInteger = Factorial.FactBig(100);
			String s = bigInteger.ToString();

			Int32 sum = s.Select(p => Convert.ToInt32(p.ToString())).Sum();
			Console.WriteLine(sum);
		}

		#endregion
	}
}