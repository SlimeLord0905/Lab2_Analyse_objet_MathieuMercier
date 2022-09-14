using SixLabors.ImageSharp;


namespace labo2
{
    public abstract class Shape
    {
        public static Color DefaultDrawColor { get; set; } = Color.Black;
        public Color DrawColor { get; set; }

        protected Shape(Color drawColor)
        {
            DrawColor = drawColor;
        }
    
        protected Shape() : this(DefaultDrawColor)
        {
        }
    }
}