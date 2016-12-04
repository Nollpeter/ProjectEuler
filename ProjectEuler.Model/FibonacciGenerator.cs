using System;

namespace ProjectEuler.Model
{
	public class FibonacciGenerator
	{
        protected Int32 CurrentValue { get; set; }
        protected Int32 PreviousValue { get; set; }

	    public FibonacciGenerator()
	    {
	        CurrentValue = PreviousValue = 1;
	    }

	    public Int32 NextValue()
	    {
	        Int32 result = CurrentValue + PreviousValue;
	        PreviousValue = CurrentValue;
	        CurrentValue = result;
            return result;
	    }
	}
}