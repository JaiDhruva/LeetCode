using IntegerToRoman;
using Xunit;

namespace IntegerToRomanTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var roman = new IntegerToRomanConverter();
            var romanString = roman.ConvertToRoman(2549);
            Assert.Equal("MMDXLIX", romanString);
        }

        [Fact]
        public void Test2()
        {
            var roman = new IntegerToRomanConverter();
            var romanString = roman.ConvertToRoman(10);
            Assert.Equal("X", romanString);
        }


        [Fact]
        public void Test3()
        {
            var roman = new IntegerToRomanConverter();
            var romanString = roman.ConvertToRoman(2);
            Assert.Equal("II", romanString);
        }
    }
}