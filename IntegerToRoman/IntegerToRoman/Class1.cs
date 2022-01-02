using System.Text;

namespace IntegerToRoman
{
    public class IntegerToRomanConverter
    {
        public string ConvertToRoman(int number)
        {
            var roman = new StringBuilder();
            if (number <= 0)
                return string.Empty;
            while (number > 0)
            {
                if (number > 1000)
                {
                    var quotient = number / 1000;
                    number = number % 1000;
                    CompileNumber(quotient, 'M', roman);
                }
                if (number >= 500 && number < 900)
                {
                    var quotient = number / 500;
                    number = number % 500;
                    CompileNumber(quotient, 'D', roman);
                }
                else if (number >= 900)
                {
                    number = number % 900;
                    CompileNumber('C', 'M', roman);
                }
                if (number >= 100 && number < 400)
                {
                    var quotient = number / 100;
                    number = number % 100;
                    CompileNumber(quotient, 'C', roman);
                }
                else if (number >= 400)
                {
                    number = number % 400;
                    CompileNumber('C', 'D', roman);
                }
                if (number >= 50 && number < 90)
                {
                    var quotient = number / 50;
                    number = number % 50;
                    CompileNumber(quotient, 'L', roman);
                }
                else if (number >= 90)
                {
                    number = number % 90;
                    CompileNumber('X', 'C', roman);
                }
                if (number >= 10 && number < 40)
                {
                    var quotient = number / 10;
                    number = number % 10;
                    CompileNumber(quotient, 'X', roman);
                }
                else if (number >= 40)
                {
                    number = number % 40;
                    CompileNumber('X', 'L', roman);
                }
                if (number >= 5 && number < 9)
                {
                    var quotient = number / 5;
                    number = number % 5;
                    CompileNumber(quotient, 'V', roman);
                }
                else if (number == 9)
                {
                    number = number % 9;
                    CompileNumber('I', 'X', roman);
                }
                if (number >= 1 && number < 5)
                {
                    var quotient = number / 1;
                    number = number % 1;
                    CompileNumber(quotient, 'I', roman);
                }
                else if (number == 4)
                {
                    number = number % 4;
                    CompileNumber('I', 'V', roman);
                }
            }
            return roman.ToString();
        }

        private void CompileNumber(char v1, char v2, StringBuilder roman)
        {
            roman.Append(v1);
            roman.Append(v2);
        }

        private void CompileNumber(int quotient, char v, StringBuilder roman)
        {
            while (quotient > 0)
            {
                roman.Append(v);
                quotient--;
            }
        }
    }
}