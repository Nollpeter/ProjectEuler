using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace ProjectEuler.Model.Tests
{
	[TestFixture]
	public class PermutationTest

	{
		[TestCase(1,1)]
		[TestCase(2, 2)]
		[TestCase(3, 6)]
		[TestCase(4, 24)]
		[TestCase(5, 120)]
		[TestCase(6, 720)]
		[TestCase(10, 3628800)]


		public void TestCounts(Int32 count,Int32 expectedCount)
		{
			Permutation permutation = new Permutation();
			String s = String.Join("", Enumerable.Range(0, count).Select(p => p.ToString()));

			IList<String> randomSortedPermutations = permutation.GetRandomSortedPermutations(s);


			Assert.AreEqual(expectedCount,randomSortedPermutations.Count);
		}

		[Test]
		public void TestValues()
		{
			Permutation permutation = new Permutation();
			IList<String> randomSortedPermutations = permutation.GetRandomSortedPermutations("012");
			String[] expected = new[] {"012", "021", "102", "120", "210", "201"};

			foreach (String s in expected)
			{
				Assert.Contains(s,(ICollection) randomSortedPermutations);
			}
		}
		
	}
}