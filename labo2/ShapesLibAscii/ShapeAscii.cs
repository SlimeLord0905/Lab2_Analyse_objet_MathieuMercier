using SixLabors.ImageSharp;

namespace labo2.ShapesLibAscii;

public abstract class ShapeAscii : Shape
{
    protected ShapeAscii(Color drawColor)
    {
        DrawColor = drawColor;
    }
    
    protected ShapeAscii() : this(DefaultDrawColor)
    {
    }

}