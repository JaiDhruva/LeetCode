namespace StrStr
{
    public class StrImplementation
    {
        public int GetNeedle(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
                return 0;
            if (haystack.Contains(needle) == false)
                return -1;
            var a=haystack.IndexOf(needle);
            return -1;
        }

    }
}