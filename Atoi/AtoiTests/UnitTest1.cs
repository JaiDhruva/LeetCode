using StringToInteger;
using Xunit;

namespace AtoiTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var atoi = new StringToIntegerConverter();
            var integer = atoi.MyAtoi("43");
            Assert.Equal(43, integer);
        }


        [Fact]
        public void Test2()
        {
            var atoi = new StringToIntegerConverter();
            var integer = atoi.MyAtoi("    my na is  -43");
            Assert.Equal(0, integer);
        }

        [Fact]
        public void Test3()
        {
            var atoi = new StringToIntegerConverter();
            var integer = atoi.MyAtoi(" ");
            Assert.Equal(0, integer);
        }
    }
}