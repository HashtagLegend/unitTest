using Microsoft.VisualStudio.TestTools.UnitTesting;
using primeservice;

namespace PrimeService.Tests
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private readonly primeservice.PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new primeservice.PrimeService();
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
    }
}
