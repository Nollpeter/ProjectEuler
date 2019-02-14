using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace ProjectEuler.Model.Tests
{
	[TestFixture]
	public class TriangleTests 
	{


		[TestCase(3,4,5,true)]
		[TestCase(1,1,10,false)]
		public void TestTriangleValidity(int a, int b, int c, Boolean expected)
		{
			Boolean isValidTriangle = Triangles.IsValidTriangle(a, b, c);

			Assert.AreEqual(expected,isValidTriangle);
		}
		[TestCase(3, 4, 5,  true)]
		[TestCase(1, 1, 10, false)]
		public void TestRightAngleTriangle(int a, int b, int c, Boolean expected)
		{
			Boolean isValidTriangle = Triangles.IsValidRightAngleTriangle(a, b, c);

			Assert.AreEqual(expected, isValidTriangle);
		}



		[TestCase(12,1)]
		[TestCase(20, 0)]
		[TestCase(120, 3)]
		[TestCase(20,0)]
		public void TestRightAngleCountsFromWireLength(Int32 length, Int32 expCount)
		{
			IEnumerable<(Int32 a, Int32 b, Int32 c)> generateRightAngleTriangles = Triangles.GenerateRightAngleTriangles(length);
			Assert.AreEqual(expCount, generateRightAngleTriangles.Count());

		}
	}
}