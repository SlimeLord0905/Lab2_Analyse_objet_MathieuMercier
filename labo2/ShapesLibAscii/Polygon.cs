using SixLabors.ImageSharp;

namespace labo2.ShapesLibAscii;

public class Polygon : ShapeAscii
{
    public List<Point> Vertices { get; set; }

    public Polygon(List<Point> vertices, Color drawColor) : base(drawColor)
    {
        this.Vertices = vertices;
    }

    public Polygon(List<Point> vertices)
    {
        this.Vertices = vertices;
    }

    public Polygon(Color drawColor, params Point[] vertices) : base(drawColor)
    {
        this.Vertices = new List<Point>(vertices);
    }

    public Polygon(params Point[] vertices) : this(DefaultDrawColor, vertices)
    {
    }

    public Polygon(Polygon polygon) : this(polygon.Vertices, polygon.DrawColor)
    {
    }

    public override void Draw(Document doc)
    {
        throw new Exception("ascii not implemented");

        
    }
}