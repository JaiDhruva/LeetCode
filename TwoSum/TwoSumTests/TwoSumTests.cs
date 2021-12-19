using TwoSum;
using Xunit;

namespace TwoSumTests
{
    public class TwoSumTests
    {
        [Fact]
        public void TwoSumWithValidInput_ReturnsSuccess()
        {
            var twoSumCalculator = new TwoSumCalculator();
            var result = twoSumCalculator.GetTwoSum(new int[4] { 2, 7, 11, 15 }, 9);
            Assert.Equal(1, result[0]);
            Assert.Equal(0, result[1]);

        }
    }
}