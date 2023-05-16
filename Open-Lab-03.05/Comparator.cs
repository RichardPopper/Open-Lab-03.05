using System;

namespace Open_Lab_03._05
{
    public class Comparator
    {
        public bool MatchCaseInsensitive(string str1, string str2)
        {
            return string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
        }
    }
}
