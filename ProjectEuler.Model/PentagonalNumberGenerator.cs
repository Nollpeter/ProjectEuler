using System;
using System.Collections.Generic;

namespace ProjectEuler.Model
{
    public class PentagonalNumberGenerator
    {
        public int Generate(int n)
        {
            return n * (3 * n - 1) / 2;
        }

        public int? Revert(int m)
        {
            double md = (double)m;

            if (Math.Sqrt(1 + 24 * md) % 1 != 0)
                return null;

            return Convert.ToInt32((1 + Math.Sqrt(1 + 24 * md)) / 6);
        }
    }

    public class PentagonalPair
    {
        public int k { get; set; }

        public int j { get; set; }

        public int Pk { get; set; }

        public int Pj { get; set; }
    }

    public class PentagonalPairsGenerator
    {
        public IList<PentagonalPair> Generate(int upToThisIndex)
        {
            PentagonalNumberGenerator generator = new PentagonalNumberGenerator();
            IList<PentagonalPair> result = new List<PentagonalPair>();

            for (int k = 1; k <= upToThisIndex; k++)
            {
                for (int j = 1; j < upToThisIndex; j++)
                {
                    if(k == j) continue;
                    int pj = generator.Generate(j);
                    int pk = generator.Generate(k);

                    if (generator.Revert(pk - pj) != null && generator.Revert(pj + pk) != null)
                    {
                        result.Add(new PentagonalPair()
                        {
                                j = j, k = k, Pj = pj, Pk = pk
                        });
                    }
                }
            }

            return result;
        }
    }
}