

using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace ProjectEuler.Model.Tests
{
	[TestFixture]
	public class DivisorsTests
	{
		[SetUp]
		public void Init() { }

		[Test]
		public void TestFor220()
		{
			IList<Int32> divisorsOfNumber = Divisors.DivisorsOfNumber(220);
			Int32[] expected = new[] {1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110};
			Assert.AreEqual(expected.Length,divisorsOfNumber.Count);

			foreach (Int32 i in expected)
			{
				Assert.Contains(i,(ICollection) divisorsOfNumber);
			}
		}

		[Test]
		public void TestFor284()
		{
			IList<Int32> divisorsOfNumber = Divisors.DivisorsOfNumber(284);
			Int32[]      expected         = new[] { 1, 2, 4, 71 ,142 };
			Assert.AreEqual(expected.Length, divisorsOfNumber.Count);

			foreach (Int32 i in expected)
			{
				Assert.Contains(i, (ICollection)divisorsOfNumber);
			}
		}


		[Test]
		public void AmicablePairs()
		{
			Boolean areAmicablePairs = Divisors.AreAmicablePairs(220, 284);
			Assert.AreEqual(true,areAmicablePairs);
		}



	}
}