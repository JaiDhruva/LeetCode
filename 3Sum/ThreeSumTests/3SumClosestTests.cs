using _3SumClosest;
using ThreeSum;
using Xunit;

namespace ThreeSumTests
{
    public class ThreeSumClosestTests
    {
        [Fact]
        public void Test1()
        {
            var sumCalculator = new ThreeSumClosestCalculator();
            var response = sumCalculator.GetThreeSumClosest(new int[] { -1, 2, 1, -4 }, 1);
            Assert.Equal(2, response);
        }

        [Fact]
        public void Test2()
        {
            var sumCalculator = new ThreeSumClosestCalculator();
            var response = sumCalculator.GetThreeSumClosest(new int[] { 1, 1, 1, 0 }, -100);
            Assert.Equal(2, response);
        }

        [Fact]
        public void Test3()
        {
            var sumCalculator = new ThreeSumClosestCalculator();
            var response = sumCalculator.GetThreeSumClosest(new int[] { 1, 1, -1, -1, 3 }, -1);
            Assert.Equal(-1, response);
        }

        [Fact]
        public void Test4()
        {
            var sumCalculator = new ThreeSumClosestCalculator();
            var response = sumCalculator.GetThreeSumClosest(new int[] { 0, 2, 1, -3 }, 1);
            Assert.Equal(0, response);
        }
    }
}