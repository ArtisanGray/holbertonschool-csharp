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
        public void MaxTest()
        {
            int result;
            List<int> bigBoy = new List<int>() { 7, 19, 2045, 3, 54, 987, 68 };
            List<int> nullBoy = new List<int>();
            List<int> negativeBoy = new List<int>() { -34, 54, -98, 0, 3, -634 };

            result = MyMath.Operations.Max(negativeBoy);
            Console.WriteLine("Negative: {0}\n", result.ToString());
            result = MyMath.Operations.Max(nullBoy);
            Console.WriteLine("Null: {0}\n", result.ToString());
            result = MyMath.Operations.Max(bigBoy);
            Console.WriteLine("Big: {0}\n", result.ToString());

        }
    }
}