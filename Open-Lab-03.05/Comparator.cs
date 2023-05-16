using System;

namespace Open_Lab_03._05
{
    public class Comparator
    {
        public bool MatchCaseInsensitive(string str1, string str2)
        {
            bool equuals = string.Equals(str1,str2, StringComparison.OrdinalIgnoreCase);
             if (equuals==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
