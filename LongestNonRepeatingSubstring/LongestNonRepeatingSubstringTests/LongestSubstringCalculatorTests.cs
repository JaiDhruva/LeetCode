using LongestNonRepeatingSubstring;
using Xunit;

namespace LongestNonRepeatingSubstringTests
{
    public class LongestSubstringCalculatorTests
    {
        [Fact]
        public void LongestSubstringCalculator_ReturnsSuccess()
        {
            var calculator = new LongestSubstringCalculator();
            var substring = calculator.GetLengthOfLongestSubstring("abcb");
            Assert.Equal(3, substring);
        }

        [Fact]
        public void LongestSubstringCalculator_WithOnlyOneCharacter()
        {
            var calculator = new LongestSubstringCalculator();
            var substring = calculator.GetLengthOfLongestSubstring("a");
            Assert.Equal(1, substring);
        }
    }
}