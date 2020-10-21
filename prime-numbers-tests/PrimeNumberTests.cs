using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using prime_numbers_app;

namespace prime_numbers_tests
{
    [TestClass]
    public class PrimeNumberTests
    {
        /// <summary>
        /// For 0-argument throws ArgumentException
        /// </summary>
        [TestMethod]
        [Description("Unit test for zero argument")]
        [TestCategory("IsPrimeNumber")]
        public void IsPrimeNumber_ZeroArg_Exception()
        {
            try
            {
                var prime = new PrimeNumber();

                //Zero is forbidden argument, so Exception must be thrown
                prime.IsPrimeNumber(0);

                Assert.Fail("ArgumentException expected");
            }
            catch (ArgumentException ex)
            {
                //Caller must know argument's name - so validate it here
                Assert.IsTrue(ex.ParamName == "number");
            }
        }

        /// <summary>
        /// For negative argument throws ArgumentException
        /// </summary>
        [TestMethod]
        [Description("Unit test for negative argument")]
        [TestCategory("IsPrimeNumber")]
        public void IsPrimeNumber_NegativeArg_Exception()
        {
            try
            {
                var prime = new PrimeNumber();

                prime.IsPrimeNumber(-1);

                Assert.Fail("ArgumentException expected");
            }
            catch (ArgumentException ex)
            {
                //Caller must know argument's name - so validate it here
                Assert.IsTrue(ex.ParamName == "number");
            }
        }

        /// <summary>
        /// For negative argument throws ArgumentException
        /// </summary>
        [TestMethod]
        [Description("Unit test for 1 is not prime number")]
        [TestCategory("IsPrimeNumber")]
        public void IsPrimeNumber_Not_PrimeNumber_1()
        {
            var prime = new PrimeNumber();
            Assert.IsFalse(prime.IsPrimeNumber(1));
        }


        /// <summary>
        /// For negative argument throws ArgumentException
        /// </summary>
        [TestMethod]
        [Description("Unit test for 7 is prime number")]
        [TestCategory("IsPrimeNumber")]
        public void IsPrimeNumber_PrimeNumber_7()
        {
            var prime = new PrimeNumber();
            Assert.IsTrue(prime.IsPrimeNumber(7));
        }


        /// <summary>
        /// For negative argument throws ArgumentException
        /// </summary>
        [TestMethod]
        [Description("Unit test for 20 is not prime number")]
        [TestCategory("IsPrimeNumber")]
        public void IsPrimeNumber_Not_PrimeNumber_20()
        {
            var prime = new PrimeNumber();
            Assert.IsFalse(prime.IsPrimeNumber(20));
        }


    }
}
