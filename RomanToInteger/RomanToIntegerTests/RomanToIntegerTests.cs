using RomanToInteger;
using StrStr;
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

        [Fact]
        public void StrImplementation()
        {
            var converter = new StrImplementation();
            var response = converter.GetNeedle("IX","X");
            Assert.Equal(9, response);

        }
    }
}