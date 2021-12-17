using System;
using System.Linq;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// string operations class.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// returns whether or not a string is a palindrome.
        /// </summary>
        /// <param name="s">string input</param>
        /// <returns>true or false, if its a palindrome</returns>
        public static bool IsPalindrome(string s)
        {
            if (s == null)
                return true;
            string pString = new string(s.Where(Char.IsLetter).ToArray());
            pString = pString.ToLower();
            return pString.SequenceEqual(pString.Reverse());
        }
    }
}
