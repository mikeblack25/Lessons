namespace Shapes
{
    /// <summary>
    /// A Square is a shape that has 4 sides that are the same size.
    /// </summary>
    public class Square
    {
        /// <summary>
        /// Size of the sqare size.
        /// </summary>
        public int Length { get; set; } // Example of a property.

        /// <summary>
        /// Calculate the area of the squre (length * length).
        /// </summary>
        /// <returns></returns>
        public int Area() // Example of a method.
        {
            return Length * Length;
        }
    }
}
