namespace Shapes
{
    /// <summary>
    /// A Rectangle is a shape that has 4 strait sides and 4 right angles.
    /// </summary>
    public class Rectangle : ShapeBase
    {
        /// <summary>
        /// Build a Rectangle object with a given length and a given height.
        /// </summary>
        /// <param name="length"><see cref="Length"/></param>
        /// <param name="height"></param>
        /// <summary>length represents one side of the rectangle where height represents a side that is perpendicular to the first side</summary>
        public Rectangle(int length, int height, Color color = 0, Texture texture = 0) : base(length, color, texture)  // Special type of method called a Constructor (same name as class).
        {
            Height = height;
        }
        
        /// <summary>
        /// Side perpendicular to the Length of the Rectangle.
        /// </summary>
        public int Height { get; set; } // Example of a property.

        /// <summary>
        /// Calculate the area of the Rectangle (length * height).
        /// </summary>
        /// <returns></returns>
        public override int Area() // Example of a method.
        {
            return Length * Height;
        }
    }
}
