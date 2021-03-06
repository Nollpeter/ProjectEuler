// <copyright file="PrimeValidatorTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Model;

namespace ProjectEuler.Model.Tests
{
    [TestClass]
    [PexClass(typeof(PrimeValidator))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PrimeValidatorTest
    {

        [PexMethod]
        public bool IsPrime([PexAssumeUnderTest]PrimeValidator target, int i)
        {
            bool result = target.IsPrime(i);
            return result;
            // TODO: add assertions to method PrimeValidatorTest.IsPrime(PrimeValidator, Int32)
        }


    }
}
