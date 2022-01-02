using RomanToInteger;
using Xunit;

namespace RomanToIntegerTests
{
    public class RomanToIntegerTests
    {
        [Fact]
        public void Test1()
        {
            var converter = new RomanToIntegerConverter();
            var response = converter.Convert("III");
            Assert.Equal(3, response);

        }

        [Fact]
        public void Test2()
        {
            var converter = new RomanToIntegerConverter();
            var response = converter.Convert("IX");
            Assert.Equal(9, response);

        }
    }
}