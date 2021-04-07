using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Model;

namespace ProjectEuler.Calculation.Problems
{
    public class Problem44 : IProblem
    {
        public void Run()
        {
            PentagonalPairsGenerator generator = new PentagonalPairsGenerator();
            IList<PentagonalPair> pentagonalPairs = generator.Generate(5000);
            List<int> list = pentagonalPairs.Select(p=>Math.Abs(p.Pj-p.Pk)).ToList();
        }
    }
}