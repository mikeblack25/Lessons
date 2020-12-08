using Shapes;

using Xunit;

namespace ShapesTests
{
    /// <summary>
    /// Test behavior of Square.
    /// </summary>
    public class SquareTests
    {
        /// <summary>
        /// Calculate the area of a Square.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="expectedArea"></param>
        [Theory]
        [InlineData(5, 25)]
        [InlineData(3, 9)]
        public void CalculateAreaTest(int length, int expectedArea)
        {
            Square square = new Square(length);

            Assert.Equal(expectedArea, square.Area());
        }
    }
}
