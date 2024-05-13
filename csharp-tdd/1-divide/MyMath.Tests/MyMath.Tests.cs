using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void MatrixIsEmpty()
        {
            int[,] values = null; 
            int num = 1;
            int[,] result = Matrix.Divide(values, num);
            Assert.AreEqual(result, null);
        }

        [Test]
        public void NumIsZero()
        {
            int[,] values = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] compare = new int[3, 2] {{ 0, 1 }, { 1, 2 }, { 2, 3 } }; 
            int num = 0;
            int[,] result = Matrix.Divide(values, num);
            Assert.AreEqual(result, null);
        }

        [Test]
        public void Positive()
        {
            int[,] values = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] compare = new int[3, 2] {{ 0, 1 }, { 1, 2 }, { 2, 3 } }; 
            int num = 2;
            int[,] result = Matrix.Divide(values, num);
            Assert.AreEqual(result, compare);
        }
    }
}