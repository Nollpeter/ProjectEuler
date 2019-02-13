using System;

namespace ProjectEuler.Calculation.Problems
{
	public class Problem19 : IProblem
	{
		#region Implementation of IProblem

		public void Run()
		{
			DateTime end = new DateTime(2000,12,31);
			Int32 count = 0;
			for (DateTime d = new DateTime(1901,01,01); d < end; d = d.AddDays(1))
			{
				if (d.Day == 1 && d.DayOfWeek == DayOfWeek.Sunday)
				{
					count++;
				}
			}

			Console.WriteLine(count);
		}

		#endregion
	}
}