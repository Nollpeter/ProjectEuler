using System;
using System.Numerics;
using ProjectEuler.Model;

namespace ProjectEuler.Calculation.Problems
{
	public class Problem25 : IProblem
	{
		#region Implementation of IProblem

		public void Run()
		{
			BigintFibonacciGenerator generator = new BigintFibonacciGenerator();
			BigInteger nextValue;
			Int32 cnt = 2;
			do
			{

				nextValue= generator.NextValue();
				cnt++;
			} while (nextValue.ToString().Length < 1000);

			Console.WriteLine(cnt);

		}

		#endregion
	}
}