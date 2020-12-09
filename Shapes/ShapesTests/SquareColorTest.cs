using Shapes;

using Xunit;

namespace ShapesTests
{
    /// <summary>
    /// Test behavior of Square.
    /// </summary>
    public class SquareColorTests
    {
        /// <summary>
        /// Calculate the area of a Square.
        /// </summary>
        /// <param name="color"></param>

        [Theory]
        [InlineData(Color1.Green)]
        public void CalculateTest(Color1 color)
        {
            SquareColor squareColor = new SquareColor(color);


            Assert.Equal(Color1.Green, squareColor.Color);
        }
    }
}
