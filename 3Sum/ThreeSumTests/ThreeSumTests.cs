using ThreeSum;
using Xunit;

namespace ThreeSumTests
{
    public class ThreeSumTests
    {
        [Fact]
        public void Test1()
        {
            var sumCalculator = new ThreeSumCalculator();
            var response = sumCalculator.GetThreeSum(new System.Collections.Generic.List<int>() { -1, 0, 1, 2, -1, -4 });
            Assert.Equal(2, response.Count);
        }
    }
}