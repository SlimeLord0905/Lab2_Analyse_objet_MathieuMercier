using SixLabors.ImageSharp;
using labo2.ShapesLibAscii;
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

        public abstract void Draw(Document doc);
    }
}