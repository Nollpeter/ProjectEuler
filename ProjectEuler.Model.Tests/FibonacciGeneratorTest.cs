// <copyright file="FibonacciGeneratorTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Model;

namespace ProjectEuler.Model.Tests
{
    [TestClass]
    [PexClass(typeof(FibonacciGenerator))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FibonacciGeneratorTest
    {

        [PexMethod]
        public int NextValue([PexAssumeUnderTest]FibonacciGenerator target)
        {
            int result = target.NextValue();
            return result;
            // TODO: add assertions to method FibonacciGeneratorTest.NextValue(FibonacciGenerator)
        }
    }
}
