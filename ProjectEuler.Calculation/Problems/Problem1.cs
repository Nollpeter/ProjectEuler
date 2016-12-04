using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Calculation.Problems
{
    public class Problem1
    {
        public void Run()
        {
            Int32 sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

    }
}
