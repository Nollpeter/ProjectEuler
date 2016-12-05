using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Model;

namespace ProjectEuler.Calculation.Problems
{
    class Problem2 : IProblem
    {
        #region Implementation of IProblem

        public void Run()
        {
            Int64 sum = 0;
            PrimeValidator validator = new PrimeValidator();
            for (int i = 0; i < 2000000; i++)
            {
                if (validator.IsPrime(i))
                    sum += i;
            }
            Console.WriteLine(sum);
        }

        #endregion
    }
}
