namespace Shapes
{
    /// <summary>
    /// A Square is a shape that has 4 sides that are the same size.
    /// </summary>
    public class SquareProperties
    {
        /// <summary>
        /// l * l
        /// </summary>
        /// <param name="length"></param>
        public SquareProperties(int length) // Special type of method called a Constructor (same name as class).
        {
            Length = length;
        }

        /// <summary>
        /// Color and Texture
        /// </summary>
        /// <param name="color"></param>
        /// <param name="texture"></param>
        public SquareProperties(Color2 color, Texture texture)
        {
            Color = color;
            Texture = texture;
        }

        /// <summary>
        /// Size of the sqare size,Color,Texture.
        /// </summary>
        public int Length { get; set; } // Example of a property.
        public Color2 Color { get; set; }

        public Texture Texture { get; set; }

        /// <summary>
        /// Calculate the area of the squre (length * length).
        /// </summary>
        /// <returns></returns>
        public int Area() // Example of a method.
        {
            return Length * Length;
        }
    }
    public enum Color2
    { Black = 1,
        Green,
        Brown,
        Red,
        Blue,
        Pink }

    public enum Texture
    {
     Soft = 1,
     Hard,
     Bumpy
    }
    
}
