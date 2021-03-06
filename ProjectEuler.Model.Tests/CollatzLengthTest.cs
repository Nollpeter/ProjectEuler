// <copyright file="CollatzLengthTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Model;

namespace ProjectEuler.Model.Tests
{
    [TestClass]
    [PexClass(typeof(CollatzLength))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CollatzLengthTest
    {

        [PexMethod]
        public int Length([PexAssumeUnderTest]CollatzLength target, int i)
        {
            int result = target.Length(i);
            return result;
            // TODO: add assertions to method CollatzLengthTest.Length(CollatzLength, Int32)
        }

        [TestMethod]
        public void Length13()
        {
            int i;
            CollatzLength s0 = new CollatzLength();
            i = this.Length(s0, 13);
            Assert.AreEqual<int>(10, i);
            Assert.IsNotNull((object)s0);
        }
    }
}
