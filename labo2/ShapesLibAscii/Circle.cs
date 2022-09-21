using SixLabors.ImageSharp;

namespace labo2.ShapesLibAscii;

public class Circle : ShapeAscii
{
    public Point Centre { get; set; }
    public int Radius { get; set; }
    public Color DrawColor { get; set; }

    public Circle(Point centre, int radius, Color drawColor)
    {
        Centre = centre;
        Radius = radius;
        DrawColor = drawColor;
    }
    
    public override void Draw(Document doc)
    {
        throw new Exception("ascii not implemented");

    }
}