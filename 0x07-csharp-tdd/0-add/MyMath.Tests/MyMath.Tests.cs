using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddCases()
        {
            int pos = 0, neg = 0, zer = 0;

            pos = MyMath.Operations.Add(98, 2);
            neg = MyMath.Operations.Add(-23, -27);
            zer = MyMath.Operations.Add(0, 0);

            Console.WriteLine("positive: {0}\nnegative: {1}\nzero: {2}", pos, neg, zer);
        }
    }
}