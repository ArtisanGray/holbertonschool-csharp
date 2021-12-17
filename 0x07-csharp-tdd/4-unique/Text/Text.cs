using System;
using System.Linq;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// string operation class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// returns the first index of a unique character.
        /// </summary>
        /// <param name="s">string input</param>
        /// <returns>indice of first match</returns>
        public static int UniqueChar(string s)
        {
            if (s == null)
                return -1;
            List<char> list = s.Distinct().ToList();
            string uniq = string.Join("", list);
            if (uniq.Length == 0)
                return -1;
            char searchChar = uniq[0];
            return (s.IndexOf(searchChar, 0));
        }
    }
}
