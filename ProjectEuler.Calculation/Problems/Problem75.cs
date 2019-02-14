using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectEuler.Model;

namespace ProjectEuler.Calculation.Problems
{
	public class Problem75 : IProblem
	{
		#region Implementation of IProblem

		public void Run()
		{
			Int32 count = 0;
			/*Parallel.For(12,
						 1500000 + 1,
						 (i) =>
						 {
							 if (i % 2 == 1) return;

							 IList<(Int32 a, Int32 b, Int32 c)> generateRightAngleTriangles = Triangles.GenerateRightAngleTriangles(i);

							 if (generateRightAngleTriangles.Count == 1)
							 {
								 count++;
								 Console.WriteLine(i);
							 }
						 });*/
			for (Int32 i = 12; i < 1500000; i++)
			{
				if(i%2==1) continue;
			
				IEnumerable<(Int32 a, Int32 b, Int32 c)> generateRightAngleTriangles = Triangles.GenerateRightAngleTriangles(i);

				Int32 cnt = 0;
				Boolean b = false;
				foreach ((Int32 a, Int32 b, Int32 c) triangle in generateRightAngleTriangles)
				{
					cnt++;
					if (cnt > 1) {b = true;
						break;
					}
				}

				if (b) continue;
				Console.WriteLine(i);
				count++;
				/*if (generateRightAngleTriangles.Count ==1)
				{
					count++;
					Console.WriteLine(i);
				}*/
				//if (generateRightAngleTriangles.Count > 2)
				//{
				//	//count++;
				//	Console.WriteLine($"{i} -> {generateRightAngleTriangles.Count}");
				//}
				//Console.WriteLine(i);
			}


			Console.WriteLine(count);
		}

		#endregion

		

	}
}