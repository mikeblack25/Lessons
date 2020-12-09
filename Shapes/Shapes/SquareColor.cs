namespace Shapes
{
    /// <summary>
    /// A Square is a shape that has 4 sides that are the same size.
    /// </summary>
    public class SquareColor
    {
        /// <summary>
        /// Build a Square object with a given length.
        /// </summary>
        /// <param name="color"></param>
        public SquareColor(Color1 color) // Special type of method called a Constructor (same name as class).
        {
            Color = color;
        }

        /// <summary>
        /// Size of the sqare size.
        /// </summary>
        public Color1 Color { get; set; } // Example of a property.
    }

    public enum Color1
    {
        Blue = 1,
        Red,
        Black,
        Green
    }
}
