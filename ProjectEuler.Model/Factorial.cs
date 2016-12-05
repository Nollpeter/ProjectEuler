using System;
using System.Numerics;

namespace ProjectEuler.Model
{
    public class Factorial
    {
        public static Int64 Fact(Int32 n)
        {
            if(n<0) throw new ArgumentOutOfRangeException(nameof(n));
            if (n <= 1) return 1;
            Int64 result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;

        }

        public static BigInteger FactBig(Int64 n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException(nameof(n));
            if (n <= 1) return 1;
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}