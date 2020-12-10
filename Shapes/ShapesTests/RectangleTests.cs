using Shapes;

using Xunit;

namespace ShapesTests
{
    /// <summary>
    /// Test behavior of Rectangle.
    /// </summary>
    public class RectangleTests
    {
        /// <summary>
        /// Calculate the area of a Rectangle.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="height"></param>
        /// <param name="expectedArea"></param>
        [Theory]
        [InlineData(2, 4, 8)]
        [InlineData(3, 9 ,27)]
        public void CalculateAreaTest(int length, int height, int expectedArea)
        {
            Rectangle rectangle = new Rectangle(length, height);

            Assert.Equal(expectedArea, rectangle.Area());
        }
    }
}
