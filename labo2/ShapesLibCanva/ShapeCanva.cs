using SixLabors.ImageSharp;

namespace labo2.ShapesLibCanva;

public abstract class ShapeCanva : Shape
{

    protected ShapeCanva(Color drawColor)
    {
        DrawColor = drawColor;
    }
    
    protected ShapeCanva() : this(DefaultDrawColor)
    {
    }

}