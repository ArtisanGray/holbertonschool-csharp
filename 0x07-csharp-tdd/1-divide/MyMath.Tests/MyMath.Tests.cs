using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMatrix()
        {
            //test unit declaration
            int[,] result;
            int[,] testMatrixSmol = new int[3, 3] { { 3, 4, 5 }, { 5, 6, 7 }, { 8, 9, 10 } };
            int[,] testMatrixNull = new int[,] { };
            int[,] testMatrixLarg = new int[5, 5] { { 3, 9, 27, 81, 243 }, { 2, 4, 6, 8, 10 }, { 20, 40, 60, 80, 100 }, { 16, 32, 64, 128, 256 }, { 1024, 2048, 4096, 8192, 16384 } };

            //result calls, small
            
            Console.WriteLine("Testing Small Matrix:");
            result = MyMath.Matrix.Divide(testMatrixSmol, 8);
            printMatrix(result);
            Console.WriteLine("--------------");
            //regular call, large
            
            Console.WriteLine("Testing Large Matrix:");
            result = MyMath.Matrix.Divide(testMatrixLarg, 4);
            printMatrix(result);
            Console.WriteLine("--------------");
            //dividebyzero
            Console.WriteLine("Testing Zero:");
            result = MyMath.Matrix.Divide(testMatrixSmol, 0);
            printMatrix(result);
            Console.WriteLine("--------------");
            Console.WriteLine("Testing Null:");
            result = MyMath.Matrix.Divide(testMatrixNull, 4);
            printMatrix(result);
            Console.WriteLine("--------------");
            Console.WriteLine("Testing Negative Number:");
            //negative
            result = MyMath.Matrix.Divide(testMatrixLarg, -4);
            printMatrix(result);
            Console.WriteLine("--------------");

        }
        public void printMatrix(int[,] sq)
        {

            if (sq == null)
            {
                Console.WriteLine("Program returned null.");
                return;
            }
            int i, j;

            for (i = 0; i < sq.GetLength(0); i++)
            {
                for (j = 0; j < sq.GetLength(1); j++)
                {
                    Console.Write(sq[i, j]);
                    if (j != sq.GetLength(1) - 1)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

}