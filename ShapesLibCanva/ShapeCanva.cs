using SixLabors.ImageSharp;
using labo2;

namespace labo2.ShapesLibCanva;

public abstract class ShapeCanva 
{
    public static Color DefaultDrawColor { get; set; } = Color.Black;
    public Color DrawColor { get; set; }

    protected ShapeCanva(Color drawColor)
    {
        DrawColor = drawColor;
    }
    
    protected ShapeCanva() : this(DefaultDrawColor)
    {
    }

    public abstract void Draw(Canvas canvas);
}