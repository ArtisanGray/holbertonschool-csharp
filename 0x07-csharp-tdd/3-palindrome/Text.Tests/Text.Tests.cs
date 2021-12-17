using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PalinTest()
        {
            Console.WriteLine("Racecar: {0}\n", Text.Str.IsPalindrome("Racecar"));
            Console.WriteLine("A man, a plan, a canal: Panama.: {0}\n", Text.Str.IsPalindrome("A man, a plan, a canal: Panama."));
            Console.WriteLine("Root beer: {0}\n", Text.Str.IsPalindrome("Root beer"));
            Console.WriteLine("Empty String: {0}", Text.Str.IsPalindrome(""));
        }
    }
}