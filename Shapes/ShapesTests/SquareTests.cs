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

        /// <summary>
        /// Check the color of the shape.
        /// </summary>
        /// <param name="color"></param>
        [Theory]
        [InlineData(Color.Green)]
        public void ColorTest(Color color)
        {
            Square squareColor = new Square(5, color: color);


            Assert.Equal(Color.Green, squareColor.Color);
        }

        /// <summary>
        /// Check the texture of the shape.
        /// </summary>
        /// <param name="texture"></param>
        [Theory]
        [InlineData(Texture.Bumpy)]
        public void TextureTest(Texture texture)
        {
            Square squareTexture = new Square(5, texture: texture);


            Assert.Equal(Texture.Bumpy, squareTexture.Texture);
        }
    }
}
