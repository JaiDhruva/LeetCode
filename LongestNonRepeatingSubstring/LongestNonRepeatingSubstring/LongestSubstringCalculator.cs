namespace LongestNonRepeatingSubstring
{
    public class LongestSubstringCalculator
    {
        public int LengthOfLongestSubstring(string s)
        {
            List<char> visited = new List<char>();
            char[] charArray = s.ToCharArray();
            string substring = string.Empty;
            string max = string.Empty;

            if (String.IsNullOrEmpty(s))
                return 0;
            int size = charArray.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    if (visited.Contains(charArray[j]) == true)
                        break;
                    else
                    {
                        substring = string.Concat(substring, charArray[j]);
                        visited.Add(charArray[j]);
                    }
                }
                max = substring.Length > max.Length ? substring : max;
                substring = string.Empty;
                visited.Clear();
            }
            if (string.IsNullOrEmpty(max))
                return 1;
            return max.Length;
        }

    }
}