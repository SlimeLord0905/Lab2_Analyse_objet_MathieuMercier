using SixLabors.ImageSharp;

namespace ShapesLibAscii;

public abstract class ShapeAscii
{
    public static Color DefaultDrawColor { get; set; } = Color.Black;
    public Color DrawColor { get; set; }

    protected ShapeAscii(Color drawColor)
    {
        DrawColor = drawColor;
    }
    
    protected ShapeAscii() : this(DefaultDrawColor)
    {
    }

    public abstract void Draw(Ascii canvas);
}