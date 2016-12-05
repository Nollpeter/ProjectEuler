using System;

namespace ProjectEuler.Model
{
    public class PrimeValidator
    {
        public Boolean IsPrime(Int32 i)
        {
            if (i <= 1) return false;
            for (int j = 2; j < (Int32)Math.Sqrt(i)+1; j++)
            {
                if (i%j == 0) return false;
                /*for (int k = 2; k < j; k++)
                {
                    if (j % k == 0) return true;
                }*/

            }
            return true;
        }
    }
}