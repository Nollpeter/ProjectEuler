using System.Collections.Generic;
using NUnit.Framework;

namespace ProjectEuler.Model.Tests
{
    [TestFixture]
    public class PentagonalNumberTests
    {
        private PentagonalNumberGenerator generator;
        private PentagonalPairsGenerator pairsGenerator;

        [SetUp]
        public void Setup()
        {
            generator = new PentagonalNumberGenerator();
            pairsGenerator = new PentagonalPairsGenerator();
        }

        [TestCase(1, 1)]
        [TestCase(2, 5)]
        [TestCase(3, 12)]
        [TestCase(4, 22)]
        [TestCase(5, 35)]
        [TestCase(6, 51)]
        [TestCase(7, 70)]
        [TestCase(8, 92)]
        [TestCase(9, 117)]
        [TestCase(10, 145)]
        public void TestGeneration(int n, int expectedResult)
        {
            Assert.That(generator.Generate(n), Is.EqualTo(expectedResult));
        }

        [TestCase(1, 1)]
        [TestCase(5, 2)]
        [TestCase(12, 3)]
        [TestCase(22, 4)]
        [TestCase(35, 5)]
        [TestCase(51, 6)]
        [TestCase(70, 7)]
        [TestCase(92, 8)]
        [TestCase(117, 9)]
        [TestCase(145, 10)]
        [TestCase(20, null)]
        [TestCase(30, null)]
        public void TestReversion(int m, int? expectedResult)
        {
            Assert.That(generator.Revert(m), Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestPairGenerationIfAllPairElementsArePentagonal()
        {
            IList<PentagonalPair> pentagonalPairs = pairsGenerator.Generate(2500);

            foreach (PentagonalPair pentagonalPair in pentagonalPairs)
            {
                int? PjInv = generator.Revert(pentagonalPair.Pj);
                int? PkInv = generator.Revert(pentagonalPair.Pk);
                Assert.That(PjInv, Is.Not.Null);
                Assert.That(PjInv, Is.EqualTo(pentagonalPair.j));
                Assert.That(PkInv, Is.Not.Null);
                Assert.That(PkInv, Is.EqualTo(pentagonalPair.k));

                int? diff = generator.Revert(pentagonalPair.Pk-pentagonalPair.Pj);
                int? sum = generator.Revert(pentagonalPair.Pj+pentagonalPair.Pk);
                
                Assert.That(diff, Is.Not.Null);
                Assert.That(sum, Is.Not.Null);
            }
        }
    }
}