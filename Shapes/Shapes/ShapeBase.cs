namespace Shapes
{
    /// <summary>
    /// Base definition of for Shapes.
    /// </summary>
    public abstract class ShapeBase
    {
        /// <summary>
        /// Construct a Shape.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="color"></param>
        /// <param name="texture"></param>
        public ShapeBase(int length, Color color = 0, Texture texture = 0)
        {
            Length = length;

            if (color != 0)
            {
                Color = color;
            }

            if (texture != 0)
            {
                Texture = texture;
            }
        }

        /// <summary>
        /// Size of a side of the Rectangle.
        /// </summary>
        public int Length { get; set; } // Example of a property.

        /// <summary>
        /// Color of the shape.
        /// </summary>
        public Color Color { get; set; } // Example of a property.

        /// <summary>
        /// Texture of the shape.
        /// </summary>
        public Texture Texture { get; set; }

        /// <summary>
        /// Calculate the area of the Rectangle (length * height).
        /// </summary>
        /// <returns></returns>
        public abstract int Area(); // Example of a method.
    }


    /// <summary>
    /// Color1 is an enumeration which represents a veriable for a given color.
    /// </summary>
    public enum Color
    {
        Blue = 1,
        Red,
        Black,
        Green
    }


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
