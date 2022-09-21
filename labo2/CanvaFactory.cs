using System.Runtime.CompilerServices;
using labo2.ShapesLibCanva;
using SixLabors.ImageSharp;

namespace labo2
{
    public class CanvaFactory : Factory
    {
        public override void addLine(int x1, int y1, int x2, int y2)
        {
            shapes.Add(new ShapesLibCanva.Line(new ShapesLibCanva.Point(x1,x2), new ShapesLibCanva.Point(x2,y2)));
        }

        public override void addCircle(int x1, int y1, int radius)
        {
            shapes.Add(new ShapesLibCanva.Circle(new ShapesLibCanva.Point(x1,y1), radius, Color.Aqua));
        }

        public override void addHLine(int x1, int y1, int width)
        {
            shapes.Add(new ShapesLibCanva.HLine(new ShapesLibCanva.Point(x1,y1), width));        
        }

        public override void addVLine(int x1, int y1, int heigth)
        {
            shapes.Add(new ShapesLibCanva.VLine(new ShapesLibCanva.Point(x1,y1), heigth));        
        }

        public override void addRectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            shapes.Add(new ShapesLibCanva.Polygon(new ShapesLibCanva.Point(x1,y1),new ShapesLibCanva.Point(x2,y2),new ShapesLibCanva.Point(x3,y3),new ShapesLibCanva.Point(x4,y4)));
        }

        public override void addTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            shapes.Add( new Triangle(new  ShapesLibCanva.Point(x1,y1),new  ShapesLibCanva.Point(x2,y2),new  ShapesLibCanva.Point(x3,y3) ));
        }

        public override Document saveFile(Document document)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(document);
            }

            return document;
        }
    }
}