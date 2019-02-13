using System;
using System.Collections.Generic;
using ProjectEuler.Model;

namespace ProjectEuler.Calculation.Problems
{
	public class Problem75 : IProblem
	{
		#region Implementation of IProblem

		public void Run()
		{
			Int32 count = 0;

			for (Int32 i = 12; i < 1500000; i++)
			{
				IList<(Int32 a, Int32 b, Int32 c)> generateRightAngleTriangles = Triangles.GenerateRightAngleTriangles(i);

				if (generateRightAngleTriangles.Count == 1)
				{
					count++;
				}
				Console.WriteLine(i);
			}


			Console.WriteLine(count);
		}

		#endregion

		

	}
}