using System;
using System.Diagnostics.Contracts;

namespace ProjectEuler.Model
{
    public class CollatzLength
    {
        [Pure]
        public Int32 Length(Int32 i)
        {
            if(i<0) throw new ArgumentOutOfRangeException(nameof(i));
            if (i == 0) return 0;
            Int32 result = 0;
            Int64 temp = i;
            while (true)
            {
                if (temp <= 0)
                {
                    
                }
                if (temp == 1) break;
                if (temp%2 == 0) temp = temp/2;
                else temp = temp*3 + 1;
                result++;
            }
            return result;
        }
    }
}