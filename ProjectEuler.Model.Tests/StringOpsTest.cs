using System;
using NUnit.Framework;

namespace ProjectEuler.Model.Tests
{
	[TestFixture]
	public class StringOpsTest
	{


		[Test]
		public void TestAlphabeticalValues()
		{
			StringOps stringOps = new StringOps();

			Int32 alphaBeticalValueOfString = stringOps.GetAlphaBeticalValueOfString("COLIN");

			Assert.AreEqual(53,alphaBeticalValueOfString);
		}
	}
}