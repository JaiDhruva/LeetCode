
using Xunit;

namespace ContainerWithMostWaterTests
{
    public class ContainerWithMostWaterTests
    {
        [Fact]
        public void Test1()
        {
            var calculator = new ContainerWithMostWaterCalculator.ContainerWithMostWaterCalculator();
            var maxArea = calculator.MaxArea(new int[9] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            Assert.Equal(49, maxArea);
        }
    }
}