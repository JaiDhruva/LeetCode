namespace StringToInteger
{
    public class StringToIntegerConverter
    {
        public int MyAtoi(string str)
        {
            var characters = str.ToCharArray();
            int i = 0;
            int num = 0;
            while (i < characters.Count() && characters[i] == ' ')
                i++;
            if (i > characters.Count()-1)
                return 0;
            int sign = 1;
            if (characters[i] == '+' || characters[i] == '-')
            {
                sign = (characters[i] == '+') ? +1 : -1;
                i++;
            }
            if (i > characters.Count()-1)
                return 0;

            for (i = i; i < str.Count() && characters[i] >= '0' && characters[i] <= '9'; i++)
            {
                if (num > Int32.MaxValue / 10 || num == Int32.MaxValue / 10 && characters[i] - '0' > Int32.MaxValue % 10)
                    return (sign == +1) ? Int32.MaxValue : Int32.MinValue;

                num = num * 10 + characters[i] - '0';
            }
            return num * sign;
        }
    }
}