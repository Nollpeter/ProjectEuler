using System;
using System.Numerics;

namespace ProjectEuler.Model
{
	public interface IFibonacciGenerator<T>
	{
		T NextValue();
	}


	public abstract class FibonacciGeneratorBase<T> : IFibonacciGenerator<T>
	{
		protected abstract T InitializeValue();

		protected abstract T Add(T first, T second);

		protected T CurrentValue { get; set; }
		protected T PreviousValue { get; set; }

		/// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
		protected FibonacciGeneratorBase()
		{
			CurrentValue = InitializeValue();
			PreviousValue = InitializeValue();
		}

		#region Implementation of IFibonacciGenerator<T>

		public T NextValue()
		{
			T result = Add(CurrentValue,PreviousValue);
			PreviousValue = CurrentValue;
			CurrentValue  = result;
			return result;
		}

		#endregion
	}
	public class BigintFibonacciGenerator : FibonacciGeneratorBase<BigInteger>
	{
		#region Overrides of FibonacciGeneratorBase<BigInteger>

		protected override BigInteger InitializeValue()
		{
			return new BigInteger(1);
		}

		protected override BigInteger Add(BigInteger first, BigInteger second)
		{
			return BigInteger.Add(first,second);
		}

		#endregion
	}

	public class FibonacciGenerator : FibonacciGeneratorBase<Int32>
	{
		protected override Int32 InitializeValue()
		{
			return 1;
		}

		protected override Int32 Add(Int32 first, Int32 second)
		{
			return first + second;
		}

		/*
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
	    }*/
	}
}