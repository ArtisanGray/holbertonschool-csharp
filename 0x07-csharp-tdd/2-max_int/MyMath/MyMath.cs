using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// math operations class.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// returns the max integer in a list.
        /// </summary>
        /// <param name="nums">list given as parameter</param>
        /// <returns>max integer.</returns>
        public static int Max(List<int> nums)
        {
            int max;
            if (nums.Count == 0)
                return 0;

            nums.Sort();
            max = nums[nums.Count - 1];
            return (max);
        }
    }
}
