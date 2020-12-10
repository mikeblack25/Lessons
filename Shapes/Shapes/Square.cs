namespace Shapes
{
    /// <summary>
    /// A Square is a shape that has 4 sides that are the same size.
    /// </summary>
    public class Square : ShapeBase
    {
        /// <summary>
        /// Build a Square object with a given length.
        /// </summary>
        /// <param name="length"></param>
        public Square(int length, Color color = 0, Texture texture = 0) : base(length, color, texture) // Special type of method called a Constructor (same name as class).
        {
        }

        /// <summary>
        /// Calculate the area of the squre (length * length).
        /// </summary>
        /// <returns></returns>
        public override int Area() // Example of a method.
        {
            return Length * Length;
        }
    }
}
