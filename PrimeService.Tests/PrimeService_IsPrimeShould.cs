
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;
        
        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);
            Assert.IsFalse(result, $"1 should not be prime");
		}
		
		[DataTestMethod]
		[DataRow(-1)]
		[DataRow(0)]
		[DataRow(1)]
		public void ReturnFalseGivenValueLessThan2(int value)
		{
			var result = _primeService.IsPrime(value);
			Assert.IsFalse(result, $"{value} should not be prime");
		}
		
		[TestMethod]
		public void ReturnTrueGivenValueIs2()
		{
			var result = _primeService.IsPrime(2);
			Assert.IsTrue(result, $"2 should be a Prime");
		}
		
		[DataTestMethod]
		[DataRow(4)]
		[DataRow(24)]
		[DataRow(1024)]
		public void ReturnFalseGivenValueIsEvenAndGreaterThan2(int value)
		{
			var result = _primeService.IsPrime(value);
			Assert.IsFalse(result, $"{value} should not be prime");
		}
		
		[DataTestMethod]
		[DataRow(3)]
		[DataRow(5)]
		[DataRow(7)]
		[DataRow(11)]
		[DataRow(13)]
		public void ReturnTrueGivenValueIsAPrimeNumber(int value)
		{
			var result = _primeService.IsPrime(value);
			Assert.IsTrue(result, $"{value} should not be prime");
		}
	}
}