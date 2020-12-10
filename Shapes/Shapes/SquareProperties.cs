namespace Shapes
{
    /// <summary>
    /// A Square is a shape that has 4 sides that are the same size aswell as its trxture and color.
    /// </summary>
    public class SquareProperties
    {
        /// <summary>
        /// length is = to one side of the square.
        /// </summary>
        /// <param name="length"></param>
        public SquareProperties(int length) // Special type of method called a Constructor (same name as class).
        {
            Length = length;
        }

        /// <summary>
        /// Color and Texture of a square.
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
        /// <summary>
        /// Color2 is an enumeration representing a given color.
        /// </summary>
    public enum Color2
    { Black = 1,
        Green,
        Brown,
        Red,
        Blue,
        Pink }
    /// <summary>
    /// Texture is an enumeration representing a given texture.
    /// </summary>
    public enum Texture
    {
     Soft = 1,
     Hard,
     Bumpy
    }
    
}
