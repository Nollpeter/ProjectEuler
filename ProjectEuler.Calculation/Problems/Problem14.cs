using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Model;

namespace ProjectEuler.Calculation.Problems
{
    public class Problem14 : IProblem
    {
        #region Implementation of IProblem

        /// <summary>
        /// Runs this instance.
        /// </summary>
        /// <remarks>
        /// The following iterative sequence is defined for the set of positive integers:
        ///n → n/2 (n is even)
        ///n → 3n + 1 (n is odd)
        ///Using the rule above and starting with 13, we generate the following sequence:
        ///13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        ///It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
        ///Which starting number, under one million, produces the longest chain?
        ///NOTE: Once the chain starts the terms are allowed to go above one million.
        /// </remarks>
        public void Run()
        {

            CollatzLength valuator = new CollatzLength();
            Int32 max = 1;
            Int32 maxValue = 1;
            IDictionary<Int32,Int32> valueWithLength = new Dictionary<Int32, Int32>();
            for (int i = 1; i < 1000000; i++)
            {
                Int32 temp = valuator.Length(i);
                valueWithLength[i] = temp;
                if (temp >= max)
                {
                    max = temp;
                    maxValue = i;
                }
            }
            Int32 max1 = valueWithLength.Max(p=>p.Value);
            IEnumerable<KeyValuePair<Int32, Int32>> keyValuePairs = valueWithLength.OrderByDescending(p => p.Value);
            Console.WriteLine("{0},{1}",max,maxValue);
        }

        #endregion
    }
}