using SixLabors.ImageSharp;

namespace ShapesLibAscii;

public class Line : ShapeAscii
{
    public Point Start { get; set; }
    public Point End { get; set; }

    public Line(Point start, Point end, Color drawColor) : base(drawColor)
    {
        Start = start;
        End = end;
    }

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public Line(Line line) : this(line.Start, line.End, line.DrawColor)
    {
    }

    public override void Draw(Ascii canvas)
    {
        throw new Exception("ascii not implemented");

      
    }
}