using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Model
{
	public class Combination
	{
		public IList<IList<T>> GenerateRandomSortedRepatedCombinations<T>(IList<T> values, Int32 comblength)
		{
			List<IList<T>> result = new List<IList<T>>();
			Generate(values,0,comblength,result,new List<T>(),0 );

			return result;
		}


		private void Generate<T>(IList<T> set, Int32 depth, Int32 maxDepth, IList<IList<T>> result,IList<T> tempRes, Int32 horIndex)
		{

			if (depth == maxDepth)
			{
				//Exit -> Add tempRes to result
				result.Add(new List<T>(tempRes));
				/*tempRes = new List<T>();*/
				tempRes.RemoveAt(tempRes.Count - 1);

			}
			else
			{
				//Continue -> Append to tempres
				for (Int32 i = horIndex; i < set.Count; i++)
				{
					tempRes.Add(set[i]);
					Generate(set, depth + 1, maxDepth, result, tempRes,i);

					
				}
				if (tempRes.Any())
				{
					tempRes.RemoveAt(tempRes.Count - 1);
				}


			}


		}

	}

	public class Permutation
	{
		public IList<String> GetRandomSortedPermutations(String s)
		{
			String[] strings = s.ToCharArray().Select(p=>p.ToString()).ToArray();

			List<String> perms = new List<String>();
			Generate(strings,0, new HashSet<String>(), perms );

			return perms;
		}	

		private void Generate(IList<String> set, Int32 pos, ICollection<String> hist, IList<String> result)
		{
			foreach (String t in set)
			{
				//We already passed this number
				if(hist.Contains(t)) continue;

				//Number is yet to be used 

				
				//String              akt      = SelectAct(set, hist);
				hist.Add(t);
				if (pos == set.Count-1)
				{
					String res = String.Join("", hist);
					
					result.Add(res);
				}
				else
				{
					
					Generate(set, pos+1, hist, result);
					
				}
				hist.Remove(t);
			}
		}

		private String SelectAct(IList<String> set, ICollection<String> hist)
		{
			for (Int32 i = 0; i < set.Count; i++)
			{
				if(hist.Contains(set[i]))
					continue;

				return set[i];

			}
			throw new NotImplementedException();
		}
	}
}