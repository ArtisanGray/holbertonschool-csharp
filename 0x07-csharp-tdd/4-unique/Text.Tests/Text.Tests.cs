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
        public void GetIndex()
        {
            Console.WriteLine("foo bar: {0}", Text.Str.UniqueChar("foo bar"));
            Console.WriteLine("oops all berries: {0}", Text.Str.UniqueChar("oops! all berries!"));
            Console.WriteLine("ooooo: {0}", Text.Str.UniqueChar("ooooo"));
            Console.WriteLine("Empty String: {0}", Text.Str.UniqueChar(""));
        }
    }
}