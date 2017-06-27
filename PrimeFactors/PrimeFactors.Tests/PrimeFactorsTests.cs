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

        [TestMethod]
        public void FactorsOfFour()
        {
            var expected = new List<int>() { 2, 2 };

            var factors = primeFactors.Factor(4);

            CollectionAssert.AreEqual(expected, factors);

        }

        [TestMethod]
        public void FactorsOfFive()
        {
            var expected = new List<int>() { 5 };

            var factors = primeFactors.Factor(5);

            CollectionAssert.AreEqual(expected, factors);

        }


        [TestMethod]
        public void FactorsOfSix()
        {
            var expected = new List<int>() { 2, 3 };

            var factors = primeFactors.Factor(6);

            CollectionAssert.AreEqual(expected, factors);

        }
        [TestMethod]
        public void FactorsOfSeven()
        {
            var expected = new List<int>() { 7 };

            var factors = primeFactors.Factor(7);

            CollectionAssert.AreEqual(expected, factors);

        }
        [TestMethod]
        public void FactorsOfEight()
        {
            var expected = new List<int>() { 2, 2, 2 };

            var factors = primeFactors.Factor(8);

            CollectionAssert.AreEqual(expected, factors);

        }
        [TestMethod]
        public void FactorsOfNine()
        {
            var expected = new List<int>() { 3, 3 };

            var factors = primeFactors.Factor(9);

            CollectionAssert.AreEqual(expected, factors);

        }
        [TestMethod]
        public void FactorsOf360()
        {
            var expected = new List<int>() { 2, 2, 2, 3, 3, 5 };

            var factors = primeFactors.Factor(360);

            CollectionAssert.AreEqual(expected, factors);

        }

    }
}
