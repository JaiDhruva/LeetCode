using Arrays;
using Xunit;

namespace ArraysTests
{
    public class Tests
    {
        [Fact]
        public void TwoDRotationTest()
        {
            var rotatate = new TwoDRotate();
            rotatate.Rotate(new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
        }
    }
}