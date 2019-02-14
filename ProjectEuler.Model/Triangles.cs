using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Model
{
	public class Triangles
	{
		public static IEnumerable<(Int32 a, Int32 b, Int32 c)> GenerateRightAngleTriangles(Int32 wireLength)
		{
			IList<(Int32 a, Int32 b, Int32 c)> res = new List<(Int32 a, Int32 b, Int32 c)>();

			Combination combination = new Combination();

			/*IList<IList<Int32>> generateRandomSortedRepatedCombinations = combination.GenerateRandomSortedRepatedCombinations(Enumerable.Range(1, wireLength-2).ToList(), 2);

			foreach (IList<Int32> combinations in generateRandomSortedRepatedCombinations)
			{
				Int32 a = combinations[0], b = combinations[1];
				if(a+b > wireLength-1) continue;

				Int32 c = (wireLength - a - b);

				if (IsValidTriangle(a, b, c))
				{
					Console.WriteLine($"{a},{b},{c} -> valid");
				}

				if (IsValidTriangle(a, b, c) && IsValidRightAngleTriangle(a, b, c))
				{
					res.Add((a, b, c));
					//Console.Write($"{a},{b},{c} -> ");
					//Console.Write("good");
					//Console.Write("\r\n");
				}
				//else { Console.Write("bad"); }

				
			}*/

			for (Int32 i = 2; i < wireLength /2; i++)
			{
				for (Int32 j = 2; j < wireLength/2; j++)
				{
			
					int c = i, b = j, a = (wireLength - i - j);

					if (a < b) break;

					//Console.Write($"{a},{b},{c} -> ");
			
					if (IsValidRightAngleTriangle(a, b, c) && IsValidTriangle(a, b, c))
					{
						//res.Add((a, b, c));

						yield return (a, b, c);

						//if (res.Count > 2) return res;

						//Console.Write("good");
					}
					//else { Console.Write("bad");}
			
					//Console.Write("\r\n");
				}
			}


			//return res;
		}

		public static Boolean IsValidRightAngleTriangle(Int32 a, int b, int c)
		{
			return ((a * a) + (b * b)) == (c * c);
		}

		public static Boolean IsValidTriangle(Int32 a, Int32 b, Int32 c)
		{
			return c < (a + b) && a <(b+c) && b < (a+c);
		}
	}
}