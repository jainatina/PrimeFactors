using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace PrimeFactors.Tests
{
    [TestClass]
    public class PrimeFactorsTests
    {
        private PrimeFact primeFactors;

        [TestInitialize]
        public void Setup()
        {
           primeFactors = new PrimeFact();
        }

        [TestMethod]
        public void FactorsOfOne()
        {
            var factors = primeFactors.Factor(1);

            Assert.IsTrue(!factors.Any());

        }
        [TestMethod]
        public void FactorsOfTwo()
        {
            var expected = new List<int>() { 2 };

            var factors = primeFactors.Factor(2);

            CollectionAssert.AreEqual(expected, factors);

        }
        [TestMethod]
        public void FactorsOfThree()
        {
            var expected = new List<int>() { 3 };

            var factors = primeFactors.Factor(3);

            CollectionAssert.AreEqual(expected, factors);

        }

    }
}
