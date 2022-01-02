namespace RomanToInteger
{
    public class RomanToIntegerConverter
    {
        public int Convert(string roman)
        {
            int preValue = 0;
            int currentValue = 0;
            int total = 0;
            foreach (char a in roman.ToCharArray())
            {
                currentValue = value(a);
                total += currentValue;
                if (preValue < currentValue)
                {
                    total = total - 2 * preValue;
                }
                preValue = currentValue;
            }
            return total;
        }

        private int value(char r)
        {
            if (r == 'I')
                return 1;
            if (r == 'V')
                return 5;
            if (r == 'X')
                return 10;
            if (r == 'L')
                return 50;
            if (r == 'C')
                return 100;
            if (r == 'D')
                return 500;
            if (r == 'M')
                return 1000;
            return -1;
        }
    }
}