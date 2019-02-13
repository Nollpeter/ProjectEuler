using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Model
{
	public class StringOps
	{
		public Int32 GetAlphaBeticalValueOfString(String s)
		{
			return s.Select(p => Convert.ToInt32(p) - 'A' + 1).Sum();
		}

		public IDictionary<String, Int32> GetNamesWithPos(String[] names)
		{
			IDictionary<String, Int32> res = new Dictionary<String, Int32>();

			IOrderedEnumerable<String> orderedEnumerable = names.OrderBy(p => p);
			Int32                      i                 = 1;
			foreach (String s in orderedEnumerable)
			{
				res[s] = i;

				i++;
			}

			return res;
		}
	}
}