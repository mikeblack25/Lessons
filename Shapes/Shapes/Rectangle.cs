namespace Shapes
{
    /// <summary>
    /// A Rectangle is a shape that has 4 strait sides and 4 right angles.
    /// </summary>
    public class Rectangle

    {
        /// <summary>
        /// Build a Rectangle object with a given length.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="height"></param>
        public Rectangle(int length, int height) // Special type of method called a Constructor (same name as class).
        {
            Length = length;
            Height = height;
        }

        /// <summary>
        /// Size of the Rectangle size.
        /// </summary>
        public int Length { get; set; } // Example of a property.
        public int Height { get; set; }
        /// <summary>
        /// Calculate the area of the Rectangle (length * length).
        /// </summary>
        /// <returns></returns>
        public int Area() // Example of a method.
        {
            return Length * Height;
        }
    }
}
