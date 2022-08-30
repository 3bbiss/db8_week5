using FindPrimes;

namespace FindPrimes_Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(7, true)]
        [InlineData(11, true)]
        [InlineData(10, false)]
        [InlineData(200, false)]
        public static void TestIsPrime(int num, bool expected)
        {
            bool actual = PrimeNumber.IsPrime(num);
            Assert.Equal(expected, actual);
        }
    }
}