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
        [Fact]
        public void CalculateAreaTest()
        {
            Square square = new Square(5);

            int area = square.Area();

            Assert.Equal(25, area);
        }
    }
}
