using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Model;

namespace ProjectEuler.Calculation.Problems
{
	public class Problem24 : IProblem
	{
		#region Implementation of IProblem

		public void Run()
		{
			Permutation permutation = new Permutation();
			IList<String> randomSortedPermutations = permutation.GetRandomSortedPermutations("0123456789");
			String[] strings = randomSortedPermutations.OrderBy(p=>p).ToArray();
			String s = strings[999999];
			Console.WriteLine(s);

		}

		#endregion
	}
}