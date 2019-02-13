using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using NUnit.Framework;

namespace ProjectEuler.Model.Tests
{
	[TestFixture]
	public class CombinatoricsTest

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

		[Test]
		public void GenerateCombinationsWithRepetitionCount()
		{
			Combination combination = new Combination();
			IList<IList<Int32>> generateRandomSortedRepatedCombinations = combination.GenerateRandomSortedRepatedCombinations(new[] {1, 2, 3}, 2);

			Assert.AreEqual(6,generateRandomSortedRepatedCombinations.Count);
		}

		[Test]
		public void GenerateCombinationsWithRepetitionValues32()
		{
			Combination         combination                             = new Combination();
			IList<IList<Int32>> generateRandomSortedRepatedCombinations = combination.GenerateRandomSortedRepatedCombinations(new[] { 1, 2, 3 }, 2);
			IList<IList<Int32>> expected = new Int32[][]
										   {
												   new Int32[] {1, 1},
												   new Int32[] {1, 2},
												   new Int32[] {1, 3},
												   new Int32[] {2, 2},
												   new Int32[] {2, 3},
												   new Int32[] {3, 3}

										   };


			foreach (IList<Int32> ints in expected)
			{
				Assert.Contains(ints,(ICollection) generateRandomSortedRepatedCombinations);
			}
		}
		[Test]
		public void GenerateCombinationsWithRepetitionCount43()
		{
			Combination         combination                             = new Combination();
			IList<IList<Int32>> generateRandomSortedRepatedCombinations = combination.GenerateRandomSortedRepatedCombinations(new[] { 1, 2, 3, 4 }, 3);

			Assert.AreEqual(20, generateRandomSortedRepatedCombinations.Count);
		}
		[Test]
		public void GenerateCombinationsWithRepetitionValues43()
		{
			Combination         combination                             = new Combination();
			IList<IList<Int32>> generateRandomSortedRepatedCombinations = combination.GenerateRandomSortedRepatedCombinations(new[] { 1, 2, 3, 4 }, 3);
			IList<IList<Int32>> expected = new Int32[][]
										   {

												new Int32[]{  1,1,1	},
												new Int32[]{  1,1,2	},
												new Int32[]{  1,1,3	},
												new Int32[]{  1,1,4	},
												new Int32[]{  1,2,2	},
												new Int32[]{  1,2,3	},
												new Int32[]{  1,2,4	},
												new Int32[]{  1,3,3	},
												new Int32[]{  1,3,4	},
												new Int32[]{  1,4,4	},
												new Int32[]{  2,2,2	},
												new Int32[]{  2,2,3	},
												new Int32[]{  2,2,4	},
												new Int32[]{  2,3,3	},
												new Int32[]{  2,3,4	},
												new Int32[]{  2,4,4	},
												new Int32[]{  3,3,3	},
												new Int32[]{  3,3,4	},
												new Int32[]{  3,4,4	},
												new Int32[]{  4,4,4 },



										   };

			foreach (IList<Int32> comb in generateRandomSortedRepatedCombinations)
			{
				Console.WriteLine($"<{String.Join(",",comb)}>");
			}

			foreach (IList<Int32> ints in expected)
			{
				Assert.Contains(ints, (ICollection)generateRandomSortedRepatedCombinations);
			}
		}
	}
}